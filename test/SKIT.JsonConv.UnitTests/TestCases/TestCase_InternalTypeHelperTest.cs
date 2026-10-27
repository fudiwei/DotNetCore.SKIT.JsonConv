namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_InternalTypeHelperTest
    {
        [Fact(DisplayName = "测试用例：工具类 `TypeHelper.IsNumberType`")]
        public void TestTypeHelper_IsNumberType()
        {
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(sbyte)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(sbyte?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(byte)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(byte?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(short)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(short?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(ushort)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(ushort?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(int)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(int?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(uint)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(uint?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(long)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(long?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(ulong)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(ulong?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(float)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(float?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(double)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(double?)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(decimal)));
            Assert.True(Shared.TypeHelper.IsNumberType(typeof(decimal?)));

            Assert.False(Shared.TypeHelper.IsNumberType(typeof(string)));
        }

        [Fact(DisplayName = "测试用例：工具类 `TypeHelper.IsArrayTypeOf`")]
        public void TestTypeHelper_IsArrayTypeOf()
        {
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(sbyte[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(sbyte?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(byte[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(byte?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(short[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(short?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(ushort[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(ushort?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(int[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(int?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(uint[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(uint?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(long[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(long?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(ulong[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(ulong?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(float[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(float?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(double[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(double?[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(decimal[]), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(decimal?[]), Shared.TypeHelper.IsNumberType));

            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(string[]), typeof(string)));
            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(string[]), typeof(IComparable)));
            Assert.False(Shared.TypeHelper.IsArrayTypeOf(typeof(string[]), Shared.TypeHelper.IsNumberType));

            Assert.True(Shared.TypeHelper.IsArrayTypeOf(typeof(object[]), typeof(object)));
        }

        [Fact(DisplayName = "测试用例：工具类 `TypeHelper.IsListTypeOf`")]
        public void TestTypeHelper_IsListTypeOf()
        {
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<sbyte>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<sbyte?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<byte>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<byte?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<short>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<short?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<ushort>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<ushort?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<int>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<int?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<uint>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<uint?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<long>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<long?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<ulong>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<ulong?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<float>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<float?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<double>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<double?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<decimal>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<decimal?>), Shared.TypeHelper.IsNumberType));

            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<sbyte>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<sbyte?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<byte>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<byte?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<short>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<short?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<ushort>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<ushort?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<int>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<int?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<uint>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<uint?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<long>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<long?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<ulong>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<ulong?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<float>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<float?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<double>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<double?>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<decimal>), Shared.TypeHelper.IsNumberType));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(List<decimal?>), Shared.TypeHelper.IsNumberType));

            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<string>), typeof(string)));
            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<string>), typeof(IComparable)));
            Assert.False(Shared.TypeHelper.IsListTypeOf(typeof(IList<string>), Shared.TypeHelper.IsNumberType));

            Assert.True(Shared.TypeHelper.IsListTypeOf(typeof(IList<object>), typeof(object)));
        }
    }
}
