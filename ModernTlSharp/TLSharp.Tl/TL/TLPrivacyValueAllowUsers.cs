using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1297858060)]
    public class TLPrivacyValueAllowUsers : TLAbsPrivacyRule
    {
        public override int Constructor => 1297858060;

        public TLVector<int> Users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Users = ObjectUtils.DeserializeVector<int>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Users, bw);

        }
    }
}
