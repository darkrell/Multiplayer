using System.Text;

namespace Multiplayer
{
    public class CustomEncodingProvider:EncodingProvider
    {
        public override Encoding GetEncoding(string name)
            =>Encoding.Default;

        public override Encoding GetEncoding(int codepage)
            =>Encoding.Default;
    }
}