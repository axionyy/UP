namespace teedst
{
    public class boom
    {
        [Fact]
        public void mew()
        {
            var exx = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            Boolean tirecks = exx.check_vin("TTT 7022366569");
            Assert.True(tirecks);
        }
        [Fact]
        public void wem()
        {
            var exx = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            Boolean tirecks = exx.check_vin("TTT 702_+&6656");
            Assert.True(tirecks);
        }
        [Fact]
        public void test1()
        {
            var rww = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            string adada = rww.get_country("___________AH____");
            Assert.Equal(adada,"ЮАР");
        }
        [Fact]
        public void test01()
        {
            var rww = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            string adada = rww.get_country("___________AH____");
            Assert.Equal(adada, "Россия");
        }

        [Fact]
        public void test2()
        {
            var rww = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            string adada = rww.get_country("___________JA____");
            Assert.Equal(adada, "Япония");
        }

        [Fact]
        public void test02()
        {
            var rww = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            string adada = rww.get_country("___________JA____");
            Assert.Equal(adada, "Россия");
        }

        [Fact]
        public void test3()
        {
            var rww = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            string adada = rww.get_country("___________SA____");
            Assert.Equal(adada, "Великобритания");
        }

        [Fact]
        public void test03()
        {
            var rww = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            string adada = rww.get_country("___________SA____");
            Assert.Equal(adada, "Россия");
        }

        [Fact]
        public void last1()
        {
            var rw = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            int ad = rw.get_year("_________A________");
            Assert.Equal(ad, 1980);
        }

        [Fact]
        public void last2()
        {
            var rw = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            int ad = rw.get_year("_________F_______");
            Assert.Equal(ad, 1985);
        }

        [Fact]
        public void last3()
        {
            var rw = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            int ad = rw.get_year("_________6_______");
            Assert.Equal(ad, 2006);
        }

        [Fact]
        public void last4()
        {
            var rw = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            int ad = rw.get_year("_________A_______");
            Assert.Equal(ad, 1990);
        }

        [Fact]
        public void last5()
        {
            var rw = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            int ad = rw.get_year("_________F_______");
            Assert.Equal(ad, 2000);
        }

        [Fact]
        public void last6()
        {
            var rw = new VIN_CALLED_YHIS_SMTH.boolean_check_vin();
            int ad = rw.get_year("_________6_______");
            Assert.Equal(ad, 1999);
        }









    }
}