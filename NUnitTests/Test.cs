using NUnit.Framework;
using System;
using ViewModel;
namespace NUnitTests
{
    [TestFixture()]
    public class TestViewModel
    {
        [Test()]
        public void TestClockViewModelTwelveOclock()
        {
            var vm = new ViewModel.AnalogClockViewModel();
            vm.Time = new DateTime(2018, 5, 1, 12, 0, 0);
            Assert.AreNotEqual(vm, null);
            Assert.AreEqual(true, (vm.AngleHours == 0 || vm.AngleHours == 360));
            Assert.AreEqual(true, (vm.AngleMinutes == 0 || vm.AngleMinutes == 360));
            Assert.AreEqual(true, (vm.Seconds == 0 || vm.Seconds == 360));
        }
        [Test()]
        public void TestClockViewModelTwelveFifteen()
        {
            var vm = new ViewModel.AnalogClockViewModel();
            vm.Time = new DateTime(2018, 5, 1, 12, 15, 0);
            Assert.AreNotEqual(vm, null);
            //Assert.AreEqual(true, (vm.AngleHours == 0 || vm.AngleHours == 360));
            Assert.AreEqual(true, (vm.AngleMinutes == 90));
            Assert.AreEqual(true, (vm.Seconds == 0 || vm.Seconds == 360));
        }

        [Test()]
        public void TestClockViewModelTwelveThirty()
        {
            var vm = new ViewModel.AnalogClockViewModel();
            vm.Time = new DateTime(2018, 5, 1, 12, 30, 0);
            Assert.AreNotEqual(vm, null);
            //Assert.AreEqual(true, (vm.AngleHours == 0 || vm.AngleHours == 360));
            Assert.AreEqual(true, (vm.AngleMinutes == 180));
            Assert.AreEqual(true, (vm.Seconds == 0 || vm.Seconds == 360));
        }
        [Test()]
        public void TestClockViewModelTwelveThirtyAndThirty()
        {
            var vm = new ViewModel.AnalogClockViewModel();
            vm.Time = new DateTime(2018, 5, 1, 12, 30, 30);
            Assert.AreNotEqual(vm, null);
            //Assert.AreEqual(true, (vm.AngleHours == 0 || vm.AngleHours == 360));
            //Assert.AreEqual(true, (vm.AngleMinutes == 180));
            Assert.AreEqual(true, (vm.Seconds == 180 ));
        }

    }

}
