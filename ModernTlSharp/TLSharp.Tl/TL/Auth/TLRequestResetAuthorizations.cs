using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Auth
{
    [TLObject(-1616179942)]
    public class TLRequestResetAuthorizations : TLMethod
    {
        public override int Constructor => -1616179942;

        public bool Response { get; set; }


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
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);

        }
    }
}
