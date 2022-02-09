using System;
using System.Collections.Generic;
using System.Linq;
using KModkit;
using UnityEngine;

public class factoryCodeScript : MonoBehaviour {

	public KMBombInfo Bomb;
	public KMAudio Audio;

	private string[] wordList = new string[]
	{
		"ABOUT",
		"ABOVE",
		"ABUSE",
		"ACTOR",
		"ACUTE",
		"ADMIT",
		"ADOPT",
		"ADULT",
		"AFTER",
		"AGAIN",
		"AGENT",
		"AGREE",
		"AHEAD",
		"ALARM",
		"ALBUM",
		"ALERT",
		"ALIKE",
		"ALIVE",
		"ALLOW",
		"ALONE",
		"ALONG",
		"ALTER",
		"AMONG",
		"ANGER",
		"ANGLE",
		"ANGRY",
		"APART",
		"APPLE",
		"APPLY",
		"ARENA",
		"ARGUE",
		"ARISE",
		"ARRAY",
		"ASIDE",
		"ASSET",
		"AUDIO",
		"AUDIT",
		"AVOID",
		"AWARD",
		"AWARE",
		"BADLY",
		"BAKER",
		"BASES",
		"BASIC",
		"BASIS",
		"BEACH",
		"BEGAN",
		"BEGIN",
		"BEGUN",
		"BEING",
		"BELOW",
		"BENCH",
		"BILLY",
		"BIRTH",
		"BLACK",
		"BLAME",
		"BLIND",
		"BLOCK",
		"BLOOD",
		"BOARD",
		"BOOST",
		"BOOTH",
		"BOUND",
		"BRAIN",
		"BRAND",
		"BREAD",
		"BREAK",
		"BREED",
		"BRIEF",
		"BRING",
		"BROAD",
		"BROKE",
		"BROWN",
		"BUILD",
		"BUILT",
		"BUYER",
		"CABLE",
		"CALIF",
		"CARRY",
		"CATCH",
		"CAUSE",
		"CHAIN",
		"CHAIR",
		"CHART",
		"CHASE",
		"CHEAP",
		"CHECK",
		"CHEST",
		"CHIEF",
		"CHILD",
		"CHINA",
		"CHOSE",
		"CIVIL",
		"CLAIM",
		"CLASS",
		"CLEAN",
		"CLEAR",
		"CLICK",
		"CLOCK",
		"CLOSE",
		"COACH",
		"COAST",
		"COULD",
		"COUNT",
		"COURT",
		"COVER",
		"CRAFT",
		"CRASH",
		"CREAM",
		"CRIME",
		"CROSS",
		"CROWD",
		"CROWN",
		"CURVE",
		"CYCLE",
		"DAILY",
		"DANCE",
		"DATED",
		"DEALT",
		"DEATH",
		"DEBUT",
		"DELAY",
		"DEPTH",
		"DOING",
		"DOUBT",
		"DOZEN",
		"DRAFT",
		"DRAMA",
		"DRAWN",
		"DREAM",
		"DRESS",
		"DRILL",
		"DRINK",
		"DRIVE",
		"DROVE",
		"DYING",
		"EAGER",
		"EARLY",
		"EARTH",
		"EIGHT",
		"ELITE",
		"EMPTY",
		"ENEMY",
		"ENJOY",
		"ENTER",
		"ENTRY",
		"EQUAL",
		"ERROR",
		"EVENT",
		"EVERY",
		"EXACT",
		"EXIST",
		"EXTRA",
		"FAITH",
		"FALSE",
		"FAULT",
		"FIBER",
		"FIELD",
		"FIFTH",
		"FIFTY",
		"FIGHT",
		"FINAL",
		"FIRST",
		"FIXED",
		"FLASH",
		"FLEET",
		"FLOOR",
		"FLUID",
		"FOCUS",
		"FORCE",
		"FORTH",
		"FORTY",
		"FORUM",
		"FOUND",
		"FRAME",
		"FRANK",
		"FRAUD",
		"FRESH",
		"FRONT",
		"FRUIT",
		"FULLY",
		"FUNNY",
		"GIANT",
		"GIVEN",
		"GLASS",
		"GLOBE",
		"GOING",
		"GRACE",
		"GRADE",
		"GRAND",
		"GRANT",
		"GRASS",
		"GREAT",
		"GREEN",
		"GROSS",
		"GROUP",
		"GROWN",
		"GUARD",
		"GUESS",
		"GUEST",
		"GUIDE",
		"HAPPY",
		"HARRY",
		"HEART",
		"HEAVY",
		"HENCE",
		"HENRY",
		"HORSE",
		"HOTEL",
		"HOUSE",
		"HUMAN",
		"IDEAL",
		"IMAGE",
		"INDEX",
		"INNER",
		"INPUT",
		"ITALY",
		"ISSUE",
		"JAPAN",
		"JIMMY",
		"JOINT",
		"JONES",
		"JUDGE",
		"KNOWN",
		"LABEL",
		"LARGE",
		"LASER",
		"LATER",
		"LAUGH",
		"LAYER",
		"LEARN",
		"LEASE",
		"LEAST",
		"LEAVE",
		"LEGAL",
		"LEVEL",
		"LEWIS",
		"LIGHT",
		"LIMIT",
		"LINKS",
		"LIVES",
		"LOCAL",
		"LOGIC",
		"LOOSE",
		"LOWER",
		"LUCKY",
		"LUNCH",
		"LYING",
		"MAGIC",
		"MAJOR",
		"MAKER",
		"MARCH",
		"MARIA",
		"MATCH",
		"MAYBE",
		"MAYOR",
		"MEANT",
		"MEDIA",
		"METAL",
		"MIGHT",
		"MINOR",
		"MINUS",
		"MIXED",
		"MODEL",
		"MONEY",
		"MONTH",
		"MORAL",
		"MOTOR",
		"MOUNT",
		"MOUSE",
		"MOUTH",
		"MOVIE",
		"MUSIC",
		"NEEDS",
		"NEVER",
		"NEWLY",
		"NIGHT",
		"NOISE",
		"NORTH",
		"NOTED",
		"NOVEL",
		"NURSE",
		"OCCUR",
		"OCEAN",
		"OFFER",
		"OFTEN",
		"ORDER",
		"OTHER",
		"OUGHT",
		"PAINT",
		"PANEL",
		"PAPER",
		"PARTY",
		"PEACE",
		"PETER",
		"PHASE",
		"PHONE",
		"PHOTO",
		"PIECE",
		"PILOT",
		"PITCH",
		"PLACE",
		"PLAIN",
		"PLANE",
		"PLANT",
		"PLATE",
		"POINT",
		"POUND",
		"POWER",
		"PRESS",
		"PRICE",
		"PRIDE",
		"PRIME",
		"PRINT",
		"PRIOR",
		"PRIZE",
		"PROOF",
		"PROUD",
		"PROVE",
		"QUEEN",
		"QUICK",
		"QUIET",
		"QUITE",
		"RADIO",
		"RAISE",
		"RANGE",
		"RAPID",
		"RATIO",
		"REACH",
		"READY",
		"REFER",
		"RIGHT",
		"RIVAL",
		"RIVER",
		"ROBIN",
		"ROGER",
		"ROMAN",
		"ROUGH",
		"ROUND",
		"ROSSI",
		"ROUTE",
		"ROYAL",
		"RURAL",
		"SCALE",
		"SCENE",
		"SCOPE",
		"SCORE",
		"SENSE",
		"SERVE",
		"SEVEN",
		"SHALL",
		"SHAPE",
		"SHARE",
		"SHARP",
		"SHEET",
		"SHELF",
		"SHELL",
		"SHIFT",
		"SHIRT",
		"SHOCK",
		"SHOOT",
		"SHORT",
		"SHOWN",
		"SIGHT",
		"SINCE",
		"SIXTH",
		"SIXTY",
		"SIZED",
		"SKILL",
		"SLEEP",
		"SLIDE",
		"SMALL",
		"SMART",
		"SMILE",
		"SMITH",
		"SMOKE",
		"SOLID",
		"SOLVE",
		"SORRY",
		"SOUND",
		"SOUTH",
		"SPACE",
		"SPARE",
		"SPEAK",
		"SPEED",
		"SPEND",
		"SPENT",
		"SPLIT",
		"SPOKE",
		"SPORT",
		"STAFF",
		"STAGE",
		"STAKE",
		"STAND",
		"START",
		"STATE",
		"STEAM",
		"STEEL",
		"STICK",
		"STILL",
		"STOCK",
		"STONE",
		"STOOD",
		"STORE",
		"STORM",
		"STORY",
		"STRIP",
		"STUCK",
		"STUDY",
		"STUFF",
		"STYLE",
		"SUGAR",
		"SUITE",
		"SUPER",
		"SWEET",
		"TABLE",
		"TAKEN",
		"TASTE",
		"TAXES",
		"TEACH",
		"TEETH",
		"TERRY",
		"TEXAS",
		"THANK",
		"THEFT",
		"THEIR",
		"THEME",
		"THERE",
		"THESE",
		"THICK",
		"THING",
		"THINK",
		"THIRD",
		"THOSE",
		"THREE",
		"THREW",
		"THROW",
		"TIGHT",
		"TIMES",
		"TIRED",
		"TITLE",
		"TODAY",
		"TOPIC",
		"TOTAL",
		"TOUCH",
		"TOUGH",
		"TOWER",
		"TRACK",
		"TRADE",
		"TRAIN",
		"TREAT",
		"TREND",
		"TRIAL",
		"TRIED",
		"TRIES",
		"TRUCK",
		"TRULY",
		"TRUST",
		"TRUTH",
		"TWICE",
		"UNDER",
		"UNDUE",
		"UNION",
		"UNITY",
		"UNTIL",
		"UPPER",
		"UPSET",
		"URBAN",
		"USAGE",
		"USUAL",
		"VALID",
		"VALUE",
		"VIDEO",
		"VIRUS",
		"VISIT",
		"VITAL",
		"VOICE",
		"WASTE",
		"WATCH",
		"WATER",
		"WHEEL",
		"WHERE",
		"WHICH",
		"WHILE",
		"WHITE",
		"WHOLE",
		"WHOSE",
		"WOMAN",
		"WOMEN",
		"WORLD",
		"WORRY",
		"WORSE",
		"WALES",
		"WORST",
		"WORTH",
		"WOULD",
		"WOUND",
		"WRITE",
		"WRONG",
		"WROTE",
		"YIELD",
		"YOUNG",
		"YOUTH",
		"ZEBRA"
	};

	private string answer = string.Empty;
	private int[] posArray = new int[4];
	private string clueChars = string.Empty;
	private string serialFirstLetter = string.Empty;
	private string logAnswer;
	private int serialLetterPosition;
	private int clueSel;

	public Renderer[] LED;
	public Material[] ledColourOptions;
	public TextMesh[] displayChars;
	public TextMesh[] clue;
	public KMSelectable btn0_0;
	public KMSelectable btn0_1;
	public KMSelectable btn1_0;
	public KMSelectable btn1_1;
	public KMSelectable btn2_0;
	public KMSelectable btn2_1;
	public KMSelectable btn3_0;
	public KMSelectable btn3_1;
	public KMSelectable submit;

	private static int moduleIdCounter = 1;
	private int moduleId;
	private bool moduleSolved;

	private void Awake()
	{
		moduleId = moduleIdCounter++;
		KMSelectable kmselectable = btn0_0;
		kmselectable.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressDownSel(btn0_0, 0);
			return false;
		}));
		KMSelectable kmselectable2 = btn1_0;
		kmselectable2.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable2.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressDownSel(btn1_0, 1);
			return false;
		}));
		KMSelectable kmselectable3 = btn2_0;
		kmselectable3.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable3.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressDownSel(btn2_0, 2);
			return false;
		}));
		KMSelectable kmselectable4 = btn3_0;
		kmselectable4.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable4.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressDownSel(btn3_0, 3);
			return false;
		}));
		KMSelectable kmselectable5 = btn0_1;
		kmselectable5.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable5.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressUpSel(btn0_1, 0);
			return false;
		}));
		KMSelectable kmselectable6 = btn1_1;
		kmselectable6.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable6.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressUpSel(btn1_1, 1);
			return false;
		}));
		KMSelectable kmselectable7 = btn2_1;
		kmselectable7.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable7.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressUpSel(btn2_1, 2);
			return false;
		}));
		KMSelectable kmselectable8 = btn3_1;
		kmselectable8.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable8.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			pressUpSel(btn3_1, 3);
			return false;
		}));
		KMSelectable kmselectable9 = submit;
		kmselectable9.OnInteract = (KMSelectable.OnInteractHandler)Delegate.Combine(kmselectable9.OnInteract, new KMSelectable.OnInteractHandler(delegate ()
		{
			submitBtn();
			return false;
		}));
		GetComponent<KMBombModule>().OnActivate += activate;
	}

	private void Start()
	{
		foreach (TextMesh textMesh in clue)
		{
			textMesh.text = string.Empty;
		}
		clueSel = UnityEngine.Random.Range(0, clue.Count());
		setup();
		clueChars = clue[clueSel].text.ToString().Replace(" ", string.Empty);
		for (int j = 0; j < 4; j++)
		{
			displayChars[j].text = clueChars.PickRandom().ToString();
			posArray[j] = clueChars.IndexOf(displayChars[j].text);
			displayChars[j].gameObject.SetActive(false);
		}
		float scalar = transform.lossyScale.x;
		for (int i = 0; i < 3; i++)
        {
			LED[i].GetComponentInChildren<Light>().range *= scalar;
			LED[i].material = ledColourOptions[0];
		}
		Debug.LogFormat("[Factory Code #{0}] Clue Stamp: {1}", moduleId, clue[clueSel].text);
		string temp;
		switch (serialLetterPosition)
        {
			case 0: temp = "⚪⚪⚫"; break;
			case 1: temp = "⚪⚫⚪"; break;
			case 2: temp = "⚪⚫⚫"; break;
			case 3: temp = "⚫⚪⚪"; break;
			default: temp = "⚫⚪⚫"; break;
		}
		Debug.LogFormat("[Factory Code #{0}] LEDs: {1}", moduleId, temp);
		Debug.LogFormat("[Factory Code #{0}] Defusal Code: {1}", moduleId, logAnswer);
	}

	private void setup()
	{
		bool flag = false;
		string text = string.Empty;
		List<int> list = new List<int>
			{
				0,
				1,
				2,
				3,
				4
			};
		if (serialFirstLetter.Equals(string.Empty))
		{
			foreach (char c in Bomb.GetSerialNumber())
			{
				if (char.IsLetter(c))
				{
					serialFirstLetter = c.ToString();
					break;
				}
			}
			if (serialFirstLetter.Equals("K") || serialFirstLetter.Equals("X") || serialFirstLetter.Equals("Z"))
			{
				list.Remove(0);
			}
			if (serialFirstLetter.Equals("J") || serialFirstLetter.Equals("K") || serialFirstLetter.Equals("Q") || serialFirstLetter.Equals("Z"))
			{
				list.Remove(1);
			}
			if (serialFirstLetter.Equals("F") || serialFirstLetter.Equals("H") || serialFirstLetter.Equals("Q"))
			{
				list.Remove(2);
			}
			if (serialFirstLetter.Equals("J") || serialFirstLetter.Equals("Q") || serialFirstLetter.Equals("X") || serialFirstLetter.Equals("Y") || serialFirstLetter.Equals("Z"))
			{
				list.Remove(3);
			}
			if (serialFirstLetter.Equals("B") || serialFirstLetter.Equals("I") || serialFirstLetter.Equals("J") || serialFirstLetter.Equals("Q") || serialFirstLetter.Equals("U") || serialFirstLetter.Equals("V") || serialFirstLetter.Equals("X") || serialFirstLetter.Equals("Z"))
			{
				list.Remove(4);
			}
		}
		serialLetterPosition = list.ElementAt(UnityEngine.Random.Range(0, list.Count()));
		list.Clear();
		IEnumerable<string> enumerable = from word in wordList
										 where word[serialLetterPosition].Equals(serialFirstLetter[0]) && word.IndexOf(serialFirstLetter) == word.LastIndexOf(serialFirstLetter)
										 select word;
		answer = enumerable.ElementAt(UnityEngine.Random.Range(0, enumerable.Count()));
		logAnswer = answer;
		answer = answer.Replace(serialFirstLetter, string.Empty);
		string text2 = string.Empty;
		List<string> list2 = new List<string>();
		foreach (string text3 in enumerable)
		{
			text2 = text3.Replace(serialFirstLetter, string.Empty);
			string text4 = answer;
			for (int j = 0; j < text4.Length; j++)
			{
				text2 = text2.Replace(text4[j].ToString(), string.Empty);
			}
			list2.Add(text2);
		}
		IEnumerable<string> enumerable2 = from word in list2
										  where word.Length == 1 || (word.Length == 2 && word[0] == word[1])
										  select word;
		string deadLetters = string.Empty;
		foreach (string text5 in enumerable2)
		{
			deadLetters += text5[0];
		}
		IEnumerable<string> enumerable3 = from word in list2
										  where word.Length == 2 && word[0] != word[1] && !deadLetters.Contains(word[0]) && !deadLetters.Contains(word[1])
										  select word;
		string text6 = string.Empty;
		foreach (string str in enumerable3)
		{
			text6 += str;
		}
		int num = 0;
		int num2 = 0;
		if (text6.Length > 0)
		{
			while (text6.Length > 0)
			{
				for (int k = 0; k < text6.Length; k++)
				{
					if (text6[0].Equals(text6[k]))
					{
						num++;
					}
				}
				if (num > num2)
				{
					text2 = text6[0].ToString();
					num2 = num;
				}
				text6 = text6.Replace(text6[0].ToString(), string.Empty);
				num = 0;
			}
		}
		else if (list2.Count() > 1)
		{
			text2 = list2.ToArray()[UnityEngine.Random.Range(0, list2.Count())].ToString();
			while (text2.Equals(""))
				text2 = list2.ToArray()[UnityEngine.Random.Range(0, list2.Count())].ToString();
			text2 = text2[UnityEngine.Random.Range(0, text2.Count())].ToString();
		}
		else
		{
			text2 = string.Empty;
		}
		do
		{
			text2 += answer;
			while (text2.Count() > 0)
			{
				if (!text.Equals(string.Empty))
				{
					text += " ";
				}
				text += text2[UnityEngine.Random.Range(0, text2.Count())];
				text2 = text2.Replace(text.Last().ToString(), string.Empty);
			}
			string[] array = new string[]
			{
					"arse",
					"bitch",
					"bum",
					"chav",
					"chode",
					"churl",
					"clit",
					"cock",
					"cunt",
					"dick",
					"dolt",
					"dope",
					"dumbo",
					"fag",
					"fatso",
					"flake",
					"freak",
					"fugly",
					"gawk",
					"gimp",
					"git",
					"ho",
					"hoe",
					"incel",
					"jerk",
					"joker",
					"klutz",
					"kevun",
					"loser",
					"lush",
					"minx",
					"nerd",
					"non",
					"oaf",
					"ogre",
					"orphan",
					"pedo",
					"paedo",
					"perv",
					"pig",
					"pleb",
					"prick",
					"quack",
					"quat",
					"rat",
					"tard",
					"serf",
					"npc",
					"shark",
					"shit",
					"shill",
					"simp",
					"sket",
					"skite",
					"slag",
					"slave",
					"slob",
					"slut",
					"snail",
					"snake",
					"snob",
					"snot",
					"sow",
					"spack",
					"sped",
					"stink",
					"swine",
					"thief",
					"toad",
					"turd",
					"vonce",
					"wacko",
					"wank",
					"whore",
					"wino",
					"witch",
					"wretch",
					"worm",
					"yutz"
			};
			foreach (string value in array)
			{
				if (text.Replace(" ", string.Empty).ToLower().Contains(value))
				{
					flag = true;
				}
			}
		}
		while (flag);
		clue[clueSel].text = text;
	}

	private void activate()
    {
		SerialLetterPositionLED();
		for (int i = 0; i < 3; i++)
        {
			if (LED[i].GetComponentInChildren<Light>().range != 0f)
				LED[i].GetComponentInChildren<Light>().enabled = true;
		}
		for (int i = 0; i < 4; i++)
			displayChars[i].gameObject.SetActive(true);
	}

	private void pressDownSel(KMSelectable obj, int dispNum)
	{
		if (!moduleSolved)
		{
			obj.AddInteractionPunch(0.5f);
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, obj.transform);
			if (posArray[dispNum] == 0)
			{
				posArray[dispNum] = clueChars.Length - 1;
				displayChars[dispNum].text = clueChars[posArray[dispNum]].ToString();
			}
			else
			{
				posArray[dispNum]--;
				displayChars[dispNum].text = clueChars[posArray[dispNum]].ToString();
			}
		}
	}

	private void pressUpSel(KMSelectable obj, int dispNum)
	{
		if (!moduleSolved)
		{
			obj.AddInteractionPunch(0.5f);
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, obj.transform);
			if (posArray[dispNum] == clueChars.Length - 1)
			{
				posArray[dispNum] = 0;
				displayChars[dispNum].text = clueChars[posArray[dispNum]].ToString();
			}
			else
			{
				posArray[dispNum]++;
				displayChars[dispNum].text = clueChars[posArray[dispNum]].ToString();
			}
		}
	}

	private void SerialLetterPositionLED()
	{
		switch (serialLetterPosition)
		{
			case 0:
				LED[0].material = ledColourOptions[1];
				LED[1].material = ledColourOptions[0];
				LED[1].GetComponentInChildren<Light>().range = 0f;
				LED[2].material = ledColourOptions[0];
				LED[2].GetComponentInChildren<Light>().range = 0f;
				break;
			case 1:
				LED[0].material = ledColourOptions[0];
				LED[0].GetComponentInChildren<Light>().range = 0f;
				LED[1].material = ledColourOptions[1];
				LED[2].material = ledColourOptions[0];
				LED[2].GetComponentInChildren<Light>().range = 0f;
				break;
			case 2:
				LED[0].material = ledColourOptions[1];
				LED[1].material = ledColourOptions[1];
				LED[2].material = ledColourOptions[0];
				LED[2].GetComponentInChildren<Light>().range = 0f;
				break;
			case 3:
				LED[0].material = ledColourOptions[0];
				LED[0].GetComponentInChildren<Light>().range = 0f;
				LED[1].material = ledColourOptions[0];
				LED[1].GetComponentInChildren<Light>().range = 0f;
				LED[2].material = ledColourOptions[1];
				break;
			case 4:
				LED[0].material = ledColourOptions[1];
				LED[1].material = ledColourOptions[0];
				LED[1].GetComponentInChildren<Light>().range = 0f;
				LED[2].material = ledColourOptions[1];
				break;
		}
	}

	private void submitBtn()
	{
		if (!moduleSolved)
		{
			submit.AddInteractionPunch(1f);
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.BigButtonPress, submit.transform);
			string text = displayChars[0].text + displayChars[1].text + displayChars[2].text + displayChars[3].text;
			if (text.Equals(answer))
			{
				moduleSolved = true;
				GetComponent<KMBombModule>().HandlePass();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			}
			else
			{
				GetComponent<KMBombModule>().HandleStrike();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.Strike, transform);
			}
		}
	}
}