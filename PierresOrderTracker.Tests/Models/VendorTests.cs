using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("SampleName", "sampleDescription");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Phils Pharmaceuticals";
      Vendor testVendor = new Vendor(name, "description");
      Assert.AreEqual(name, testVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Phils Pharmaceuticals";
      string description ="Oxycodone Dealer";
      Vendor testVendor = new Vendor(name, description);
      Assert.AreEqual(description, testVendor.Description);
    }
  }
}