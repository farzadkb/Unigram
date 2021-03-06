// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLStickerSetCovered : TLObject 
	{
		public TLStickerSet Set { get; set; }
		public TLDocumentBase Cover { get; set; }

		public TLStickerSetCovered() { }
		public TLStickerSetCovered(TLBinaryReader from, TLType type = TLType.StickerSetCovered)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.StickerSetCovered; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.StickerSetCovered)
		{
			Set = TLFactory.Read<TLStickerSet>(from);
			Cover = TLFactory.Read<TLDocumentBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6410A5D2);
			to.WriteObject(Set);
			to.WriteObject(Cover);
		}
	}
}