// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLContactLinkContact : TLContactLinkBase 
	{
		public TLContactLinkContact() { }
		public TLContactLinkContact(TLBinaryReader from, TLType type = TLType.ContactLinkContact)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ContactLinkContact; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ContactLinkContact)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xD502C2D0);
		}
	}
}