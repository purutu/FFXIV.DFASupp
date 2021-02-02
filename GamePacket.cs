using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFASupp
{
	class GamePacket
	{
		//public string Version { get; set; } = 0;
		public ushort OpFate { get; set; } = 0;
		public ushort FateIndex { get; set; } = 0;
		public ushort OpDuty { get; set; } = 0;
		public ushort DutyRoulette { get; set; } = 0;
		public ushort DutyInstance { get; set; } = 0;
		public ushort OpMatch { get; set; } = 0;
		public ushort MatchRoulette { get; set; } = 0;
		public ushort MatchInstance { get; set; } = 0;
		public ushort OpInstance { get; set; } = 0;
		public ushort InstanceInstance { get; set; } = 0;
		public ushort OpBozjaCe { get; set; } = 0;
	}
}
