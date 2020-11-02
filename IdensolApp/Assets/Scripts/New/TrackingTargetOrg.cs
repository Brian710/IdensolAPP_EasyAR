using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DigitalRubyShared;

public class TrackingTargetOrg : MonoBehaviour
{
    public float minScale;
    public float mixScale;


    //string targetName;


    [SerializeField]
    GameObject[] objs;

    GameObject targetObj;

    [SerializeField]
    Transform povit;

    Camera mainCamera;

    Transform cameraPosition;

    Transform orgParent;

    readonly Vector3 ZeroVec3 = new Vector3(0f, 0f, 0f);

    Vector3 povitOrgPos;
    Vector3 povitOrgRot;
    Vector3 cameraOrgPos;

    Vector3 offset = new Vector3(0f, 0f, 0f);

    bool isLock = false;

    float rotY = 0f;

    [SerializeField]
    float limitY = 50f;

    private TapGestureRecognizer doubleTapGesture;
    private PanGestureRecognizer panGesture;
    //private ScaleGestureRecognizer scaleGesture;
    private PanGestureRecognizer rotPanGesture;
    float curScale;

    public string targetName { private set; get; }

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Start()
    {
        if(!Input.multiTouchEnabled)
        {
            Input.multiTouchEnabled = true;
        }

        if(mainCamera == null)
        {
            mainCamera = Camera.main;
        }

        cameraPosition = povit.GetChild(0);
        //Debug.Log("" + cameraPosition.name);

        orgParent = mainCamera.transform.parent;

        povitOrgPos = povit.position;
        povitOrgRot = povit.localEulerAngles;
        cameraOrgPos = cameraPosition.localPosition;
        curScale = cameraOrgPos.y;
        //縮放
        var pitchRecognizer = new TKPinchRecognizer();
        pitchRecognizer.minimumScaleDistanceToRecognize = 1f;
        pitchRecognizer.gestureRecognizedEvent += (r) =>
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                float targetScale = curScale - pitchRecognizer.deltaScale;
                if(targetScale >= mixScale && targetScale <= minScale)
                {
                    curScale = targetScale;
                    cameraPosition.localPosition += new Vector3(0f, pitchRecognizer.deltaScale, 0f);
                }
                //Debug.Log("pinch recognizer fired: " + r);
            }
        };
        TouchKit.addGestureRecognizer(pitchRecognizer);

        CreateDoubleTapGesture();
        CreatePanGesture();
        CreateRotationPanGesture();
    }

    public void CreateDoubleTapGesture()
    {
        doubleTapGesture = new TapGestureRecognizer();
        doubleTapGesture.NumberOfTapsRequired = 2;
        doubleTapGesture.StateUpdated += DoubleTapGestureCallback;
        FingersScript.Instance.AddGesture(doubleTapGesture);
    }

    public void DoubleTapGestureCallback(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                povit.localPosition = povitOrgPos;
                povit.localEulerAngles = povitOrgRot;
                cameraPosition.localPosition = cameraOrgPos;
                offset = ZeroVec3;
                rotY = 0f;
                curScale = cameraOrgPos.y;
            }
        }
    }


    private void CreatePanGesture()
    {
        panGesture = new PanGestureRecognizer();
        panGesture.MinimumNumberOfTouchesToTrack = 2;
        panGesture.StateUpdated += PanGestureCallback;
        FingersScript.Instance.AddGesture(panGesture);
    }

    private void PanGestureCallback(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Executing)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                float deltaX = panGesture.DeltaX / 25.0f;
                float deltaY = panGesture.DeltaY / 25.0f;
                cameraPosition.Translate(-new Vector3(deltaX, deltaY, 0f) * 0.01f, Space.Self);
            }
        }
    }

    private void CreateRotationPanGesture()
    {
        rotPanGesture = new PanGestureRecognizer();
        rotPanGesture.MaximumNumberOfTouchesToTrack = 1;
        rotPanGesture.StateUpdated += RotationPanGestureCallback;
        FingersScript.Instance.AddGesture(rotPanGesture);
    }

    private void RotationPanGestureCallback(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Executing)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                float deltaX = panGesture.DeltaX * 0.2f;
                float deltaY = panGesture.DeltaY * 0.2f;
                float targetY = rotY - deltaY;
                float absY = Mathf.Sqrt(targetY * targetY);
                if (absY < limitY)
                {
                    rotY += -deltaY;
                    povit.Rotate(Vector3.right, -deltaY, Space.Self);
                }
                povit.Rotate(Vector3.down, -deltaX, Space.World);
            }
        }
    }

    public void SetTarget(string name)
    {
        if(isLock)
        {
            return;
        }
        targetName = name;
        if (!string.IsNullOrEmpty(name))
        {
            foreach (var obj in objs)
            {
                if (name.Contains(obj.name))
                {
                    targetObj = obj;
                    break;
                }
            }
        }
        else
        {
            if (targetObj != null)
            {
                targetObj.SetActive(false);
            }
        }
    }
    
    void LateUpdate()
    {
        if (isLock)
        {
            mainCamera.transform.localPosition = ZeroVec3;
            mainCamera.transform.localEulerAngles = ZeroVec3;
        }
    }
    
    public bool SetLockState(bool newLockState)
    {
        isLock = newLockState;

        if (targetObj != null)
        {
            targetObj.SetActive(newLockState);
        }
        else
        {
            isLock = false;
            return isLock;
        }

        if(newLockState)
        {
            Vuforia.TrackerManager.Instance.GetTracker<Vuforia.ObjectTracker>().Stop();

            mainCamera.transform.SetParent(cameraPosition);
            mainCamera.transform.localPosition = ZeroVec3;
            mainCamera.transform.localEulerAngles = ZeroVec3;
        }
        else
        {
            //reset all positions and rotations
            mainCamera.transform.SetParent(orgParent);
            mainCamera.transform.localPosition = ZeroVec3;
            mainCamera.transform.localEulerAngles = ZeroVec3;

            povit.localPosition = povitOrgPos;
            povit.localEulerAngles = povitOrgRot;

            cameraPosition.localPosition = cameraOrgPos;
            offset = ZeroVec3;
            rotY = 0f;
            curScale = cameraOrgPos.y;
            //povit.localScale = new Vector3(1f, 1f, 1f);
            targetObj = null;
            Vuforia.TrackerManager.Instance.GetTracker<Vuforia.ObjectTracker>().Start();
        }

        //btnGroup.Select(isLock ? targetName : "");

        return isLock;

    }
    public void Back()
    {
        povit.localPosition = povitOrgPos;
        povit.localEulerAngles = povitOrgRot;
        cameraPosition.localPosition = cameraOrgPos;
        offset = ZeroVec3;
        rotY = 0f;
        curScale = cameraOrgPos.y;
        
    }
}
