using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL
{
    [TLObject(1218642516)]
    public class TLReplyInlineMarkup : TLAbsReplyMarkup
    {
        public override int Constructor => 1218642516;

        public TLVector<TLKeyboardButtonRow> Rows { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Rows = ObjectUtils.DeserializeVector<TLKeyboardButtonRow>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Rows, bw);

        }
    }
}
