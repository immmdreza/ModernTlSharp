using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(2011940674)]
    public class TLUserStatusLastMonth : TLAbsUserStatus
    {
        public override int Constructor => 2011940674;



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
