using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(-697604407)]
    public class TLInputPrivacyValueDisallowAll : TLAbsInputPrivacyRule
    {
        public override int Constructor => -697604407;



        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);

        }
    }
}
