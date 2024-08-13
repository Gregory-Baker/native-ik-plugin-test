using UnityEngine;
using System;
using TMPro;

namespace IK
{
    public class IKTest : MonoBehaviour
    {
        [SerializeField] string urdfString;
        [SerializeField] string baseLink;
        [SerializeField] string endEffectorLink;
        [SerializeField] TextMeshProUGUI outputText;

        private TRAC_IK tracIK;

        // Start is called before the first frame update
        void Start()
        {
            double timeout = 0.005; // Maximum time to solve the IK problem
            double epsilon = 1e-5;  // Desired accuracy for the solution
            string solveType = "Speed"; 
            try
            {
                tracIK = new TRAC_IK(baseLink, endEffectorLink, urdfString, timeout, epsilon, solveType);
            }
            catch (Exception ex)
            {
                Debug.LogError("Error creating TRAC_IK instance.");
                Debug.LogError(ex.Message);
                return;
            }

            Debug.Log("TRAC_IK instance created");
            string[] linkNames = tracIK.getLinkNamesInChain().ToArray();
            Debug.Log("Links in kinematics chain: " + string.Join(", ", linkNames));
            outputText.text = "Links in kinematics chain: " + string.Join(", ", linkNames);
        }

        public void GetJointAngles() {
            if (tracIK == null) {
                Debug.LogError("TRAC_IK instance not created");
            }

            double[] qinit = new double[6];
            for (int i = 0; i < 6; i++)
            {
                qinit[i] = UnityEngine.Random.Range(-Mathf.PI, Mathf.PI);
            }

            Vector3 position = transform.position;
            position.x = UnityEngine.Random.Range(-0.5f, 0.5f);
            position.y = UnityEngine.Random.Range(-0.5f, 0.5f);
            position.z = UnityEngine.Random.Range(-0.5f, 0.5f);
            Quaternion rotation = UnityEngine.Random.rotation;
            gameObject.transform.position = position;
            gameObject.transform.rotation = rotation;
            Debug.Log("Target Position: " + position + ", Target Rotation: " + rotation);

            double[] jointAngles = tracIK.CartToJnt(new DoubleVector(qinit), position.z, -position.x, position.y, rotation.z, -rotation.x, rotation.y, -rotation.w).ToArray();

            double[] jointAnglesDeg = new double[jointAngles.Length];
            for (int i = 0; i < jointAngles.Length; i++)
            {
                jointAnglesDeg[i] = jointAngles[i] * 180 / Math.PI;
            }
            if (jointAngles.Length == 0)
            {
                Debug.LogError("Failed to solve IK request");
                outputText.text = "Failed to solve IK request";
            }
            else
            {
                Debug.Log("Joint Angles: " + string.Join(", ", jointAnglesDeg));
                outputText.text = "Joint Angles: " + string.Join(", ", jointAnglesDeg);
            }
        }
    }
}
