using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;
using System.Collections.Generic;

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

    [TestMethod]
    public void GetId_ReturnsUniqueId_Int()
    {
      Vendor testVendor1 = new Vendor("name1", "description1");
      Vendor testVendor2 = new Vendor("name2", "description2");

      Assert.AreNotEqual(testVendor1.Id, testVendor2.Id);
    }

    [TestMethod]
    public void GetAllVendors_ReturnsEmptyList_VendorList()
    {
      List<Vendor> vendorList = new List<Vendor>{};
      CollectionAssert.AreEqual(vendorList, Vendor.AllVendors);
    }

    [TestMethod]
    public void GetAllVendors_ReturnsEveryInstantiatedVendor_ListOfVendors()
    {
      Vendor testVendor1 = new Vendor("name1", "description1");
      Vendor testVendor2 = new Vendor("name2", "description2");
      Vendor testVendor3 = new Vendor("name3", "description3");
      List<Vendor> vendorList = new List<Vendor>{};
      vendorList.Add(testVendor1);
      vendorList.Add(testVendor2);
      vendorList.Add(testVendor3);

      CollectionAssert.AreEqual(vendorList, Vendor.AllVendors);
    }
  }
}