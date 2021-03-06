// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method rpc_drop_answer
	/// </summary>
	public partial class TLRPCDropAnswer : TLObject
	{
		public Int64 ReqMsgId { get; set; }

		public TLRPCDropAnswer() { }
		public TLRPCDropAnswer(TLBinaryReader from, TLType type = TLType.RPCDropAnswer)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.RPCDropAnswer; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.RPCDropAnswer)
		{
			ReqMsgId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x58E4A740);
			to.Write(ReqMsgId);
		}
	}
}