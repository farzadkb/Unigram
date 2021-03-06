// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.updateNotifySettings
	/// </summary>
	public partial class TLAccountUpdateNotifySettings : TLObject
	{
		public TLInputNotifyPeerBase Peer { get; set; }
		public TLInputPeerNotifySettings Settings { get; set; }

		public TLAccountUpdateNotifySettings() { }
		public TLAccountUpdateNotifySettings(TLBinaryReader from, TLType type = TLType.AccountUpdateNotifySettings)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AccountUpdateNotifySettings; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AccountUpdateNotifySettings)
		{
			Peer = TLFactory.Read<TLInputNotifyPeerBase>(from);
			Settings = TLFactory.Read<TLInputPeerNotifySettings>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x84BE5B93);
			to.WriteObject(Peer);
			to.WriteObject(Settings);
		}
	}
}