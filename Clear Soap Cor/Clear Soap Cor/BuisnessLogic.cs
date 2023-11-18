using System.ServiceModel;

namespace Clear_Soap_Cor
{
    public class BuisnessLogic
    {
        [ServiceContract]
        public interface ISoapService
        {
            [OperationContract]
            string MaxChar(string str);
        }

        public class SoapService : ISoapService
        {
            public string MaxChar(string str)
            {
                Dictionary<char, int> charCount = new Dictionary<char, int>();

                foreach (char c in str)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }

                char mostFrequentChar = charCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

                return mostFrequentChar.ToString();
            }
        }
    }
}
