// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.clearRecentStickers
	/// </summary>
	public partial class TLMessagesClearRecentStickers : TLObject
	{
		public TLMessagesClearRecentStickers() { }
		public TLMessagesClearRecentStickers(TLBinaryReader from, TLType type = TLType.MessagesClearRecentStickers)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesClearRecentStickers; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesClearRecentStickers)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAB02E5D2);
		}
	}
}