using System.IO;
namespace ModernTlSharp.TLSharp.Tl.TL.Messages
{
    [TLObject(904138920)]
    public class TLStickerSetInstallResultArchive : TLAbsStickerSetInstallResult
    {
        public override int Constructor => 904138920;

        public TLVector<TLAbsStickerSetCovered> Sets { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Sets = (TLVector<TLAbsStickerSetCovered>)ObjectUtils.DeserializeVector<TLAbsStickerSetCovered>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Sets, bw);

        }
    }
}
