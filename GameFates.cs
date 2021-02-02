using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFASupp
{
	class GameFates
	{
		static short[] FateCodes =
		{
			553, 649, 687, 688, 693, 717,
			220, 221, 222, 223, 225, 226, 227, 229, 231, 233, 235, 237, 238, 239, 240,
			1387,

			// 보즈야
			1597, 1598, 1599,
			1600, 1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609,
			1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619,
			1620, 1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628
		};

		struct FateType
		{
			public int index;
			public string name;

			public FateType(int i, string n)
			{
				index = i;
				name = n;
			}
		}

		static FateType[] FateTypes = new FateType[]
		{
			new FateType(0, "none"),
			new FateType(220, "Menuis at Work"),
			new FateType(221, "Overnight Migration"),
			new FateType(222, "Go Wespe"),
			new FateType(223, "A Mad, Mad, Mad Sergeant"),
			new FateType(225, "Thwack-a-Mole"),
			new FateType(226, "Yellow-bellied Greenbacks"),
			new FateType(227, "On the Lamb"),
			new FateType(229, "The Orange Boxes"),
			new FateType(231, "Shearing Is Caring"),
			new FateType(233, "The Boy Who Cried Jackal"),
			new FateType(235, "Sister Crustacean"),
			new FateType(237, "Hello, Work"),
			new FateType(238, "The Truth Is out There"),
			new FateType(239, "Taking It to the Streams"),
			new FateType(240, "Crying over Spilled Salt"),
			new FateType(533, "Return of the King"),
			new FateType(649, "Sister Crustacean"),
			new FateType(687, "Embiggened Spriggans"),
			new FateType(688, "Tower of Power"),
			new FateType(693, "Stay Frosty"),
			new FateType(717, "Gloria in Eggcelsis"),
			new FateType(245, "One Prince"),
			new FateType(246, "Fight the Flower"),
			new FateType(249, "You Call That a Toad"),
			new FateType(250, "Caving In"),
			new FateType(251, "Man of the Flour"),
			new FateType(257, "I Melt with You"),
			new FateType(260, "Away in a Bilge Hold"),
			new FateType(261, "In the Name of Love"),
			new FateType(262, "Don`t Drink the Water"),
			new FateType(264, "Enter Beastman"),
			new FateType(265, "One Pickman Enters"),
			new FateType(333, "Under the Bridge"),
			new FateType(534, "Return of the King"),
			new FateType(666, "Brick by Brick"),
			new FateType(667, "Brick by Stone Brick"),
			new FateType(694, "Stay Frosty"),
			new FateType(718, "Gloria in Eggcelsis"),
			new FateType(267, "Finding Wine"),
			new FateType(268, "The Thirst"),
			new FateType(271, "Thrill of the Hunt"),
			new FateType(272, "The Pelican Briefing"),
			new FateType(274, "Them"),
			new FateType(278, "Careless Whiskers"),
			new FateType(279, "No Lip"),
			new FateType(280, "Jewels of the Isle"),
			new FateType(282, "Crab and Go"),
			new FateType(286, "Follow the Light"),
			new FateType(287, "Just a Matter of Rut"),
			new FateType(334, "Consigned, Sealed, and Undelivered"),
			new FateType(335, "It`s Not Lupus"),
			new FateType(532, "Return of the King"),
			new FateType(560, "9 to 5"),
			new FateType(561, "Closing Time"),
			new FateType(562, "Sweeter than Honey"),
			new FateType(563, "Ho Ho Ho"),
			new FateType(564, "Say My Name"),
			new FateType(565, "Long Way Home"),
			new FateType(566, "Cliff Hanger"),
			new FateType(689, "Embiggened Spriggans"),
			new FateType(690, "Tower of Power"),
			new FateType(701, "What`s Yours Is Mine"),
			new FateType(913, "The Sarong Song"),
			new FateType(914, "The Belle of the Beach"),
			new FateType(915, "Sparking Up the Wrong Beach"),
			new FateType(916, "It Came from Beneath the Deep"),
			new FateType(917, "Life`s a Beach"),
			new FateType(918, "Feeling Groggy"),
			new FateType(945, "-----"),
			new FateType(946, "-----"),
			new FateType(289, "Absolutely, Positively"),
			new FateType(290, "Tender Buttons"),
			new FateType(291, "The Killing Fields"),
			new FateType(295, "(I Just) Died in Six Arms Tonight"),
			new FateType(297, "Iron Contra Affair"),
			new FateType(298, "Don`t Call Him a Fishback"),
			new FateType(303, "Letters from Tidegate"),
			new FateType(304, "The Last Straw"),
			new FateType(306, "Barometz Soup"),
			new FateType(308, "Goblin Chain"),
			new FateType(309, "Tryp Fantastic"),
			new FateType(310, "Between Aurochs"),
			new FateType(312, "In the Sac"),
			new FateType(336, "The Mandragoras"),
			new FateType(568, "Gauging North Tidegate"),
			new FateType(569, "Breaching North Tidegate"),
			new FateType(570, "Gauging South Tidegate"),
			new FateType(571, "Breaching South Tidegate"),
			new FateType(572, "Sharknado"),
			new FateType(574, "Tail of a Whale"),
			new FateType(575, "Watch Your Tongue"),
			new FateType(576, "Dead Man`s Rest"),
			new FateType(577, "The King`s Justice"),
			new FateType(578, "Making Waves"),
			new FateType(650, "Tender Buttons"),
			new FateType(702, "Eggcelsior"),
			new FateType(314, "Simurgh Is the Word"),
			new FateType(317, "Surprise"),
			new FateType(320, "The Road More Traveled"),
			new FateType(321, "Nine-ilm Snails"),
			new FateType(322, "Truth in Faerie Tales"),
			new FateType(323, "Giant Enemy Crab"),
			new FateType(329, "Shell Shocked"),
			new FateType(331, "Peeping Ja"),
			new FateType(332, "Hop, Skip, and a Jump"),
			new FateType(451, "Poor Maid`s Mess"),
			new FateType(452, "Poor Maid`s Mishap"),
			new FateType(453, "Poor Maid`s Misfortune"),
			new FateType(454, "Poor Maid`s Misadventure"),
			new FateType(668, "Brick by Brick"),
			new FateType(669, "Brick by Stone Brick"),
			new FateType(670, "Brick by Brick"),
			new FateType(671, "Brick by Gold Brick"),
			new FateType(703, "What`s Yours Is Mine"),

			// 보즈야
			new FateType(1597, "Sneak & Spell"),
			new FateType(1598, "None of Them Knew They Were Robots"),
			new FateType(1599, "The Bests Must Die"),
			new FateType(1600, "Unrest for the Wicked"),
			new FateType(1601, "1601"),
			new FateType(1602, "Can Carnivorous Plants"),
			new FateType(1603, "Seeq and Destroy"),
			new FateType(1604, "All Pets Are Off"),
			new FateType(1605, "Conflicting with the First Law"),
			new FateType(1607, "Sneak & Spell"),
			new FateType(1606, "The monster mash"),
			new FateType(1607, ""),
			new FateType(1608, ""),
			new FateType(1609, "Unicorn Flakes"),
			new FateType(1610, "Parts and Recreation"),
			new FateType(1611, "The Element of Supplies"),
			new FateType(1612, "Can Carnivorous Plants"),
			new FateType(1613, "No Camping Allowed"),
			new FateType(1614, "Scavengers of Human Sorrow"),
			new FateType(1615, "Help Wanted"),
			new FateType(1616, "Pyromancer Supreme"),
			new FateType(1617, "Waste the Rainbow"),
			new FateType(1618, "The Wild Bunch"),
			new FateType(1619, "My Family and Other Animals"),
			new FateType(1620, "I'm Mechanical Man"),
			new FateType(1621, "Murder Death Kill"),
			new FateType(1622, "Desper"),
			new FateType(1623, "Supplies Party"),
			new FateType(1624, "Demonstrably Demonic"),
			new FateType(1625, ""),
			new FateType(1626, ""),
			new FateType(1627, "Let Slip the Dogs of War"),
			new FateType(1628, "The War Against the Machines"),

			new FateType(30000, "CE: The Battle of Castrum Lacus Litore "),
			new FateType(30001, "CE: Kill It with Fire"),
			new FateType(30002, "CE: The Baying of the Hound(s)"),
			new FateType(30003, "CE: Vigil for the Lost "),
			new FateType(30004, "CE: Aces High"),
			new FateType(30005, "CE: The Shadow of Death's Hand "),
			new FateType(30006, "CE: The Final Furlong"),
			new FateType(30007, "CE: The Hunt for Red Choctober "),
			new FateType(30008, "CE: Beast of Man"),
			new FateType(30009, "CE: The Fires of War"),
			new FateType(30010, "CE: Patriot Games"),
			new FateType(30011, "CE: Trampled under Hoof"),
			new FateType(30012, "CE: And the Flames Went Higher "),
			new FateType(30013, "CE: Metal Fox Chaos"),
			new FateType(30014, "CE: Rise of the Robots"),
			new FateType(30015, "CE: Where Strode the Behemoth "),
		};

		public static string GetFate(int index)
		{
			foreach (var f in FateTypes)
				if (f.index == index)
					return f.name;

			return "(unknown)";
		}

		public static bool IsTargetFate(short code)
		{
			return FateCodes.Contains(code);
		}
	}
}
