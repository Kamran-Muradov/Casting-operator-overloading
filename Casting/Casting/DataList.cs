namespace Casting
{
    public class DataList
    {
        public string[] datas = new string[10];

        public string this[int index]
        {
            get
            {
                return datas[index];
            }
            set
            {
                datas[index] = value;
            }
        }
    }
}
