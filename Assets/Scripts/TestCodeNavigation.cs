using MyPackage;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestCodeNavigation : MonoBehaviour
{
    public void TestMethod()
    {
        var inputDevice = InputSystem.GetDevice("Mouse");
        var number = MyPackageScript.Calc();
        TestMethod2();
    }

    /// <summary>
    /// Test 2
    /// </summary>
    public void TestMethod2()
    {
        var inputDevice = InputSystem.GetDevice("Keyboard");
        var number = MyPackageScript.Calc();
    }
}