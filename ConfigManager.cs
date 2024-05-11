using BepInEx.Configuration;
using System.Collections.Generic;

namespace CursedScraps
{
    internal class ConfigManager
    {
        // GLOBAL
        public static ConfigEntry<string> globalChance;
        public static ConfigEntry<bool> globalPrevent;
        // HIDE MECHANIC
        public static ConfigEntry<string> hidingMode;
        public static ConfigEntry<int> hidingCounter;
        // ANTI-CURSE PILLS
        public static ConfigEntry<bool> isPills;
        public static ConfigEntry<float> pillsChance;
        // INHIBITION
        public static ConfigEntry<bool> isInhibition;
        public static ConfigEntry<float> inhibitionMultiplier;
        public static ConfigEntry<string> inhibitionWeight;
        // CONFUSION
        public static ConfigEntry<bool> isConfusion;
        public static ConfigEntry<float> confusionMultiplier;
        public static ConfigEntry<string> confusionWeight;
        // CAPTIVE
        public static ConfigEntry<bool> isCaptive;
        public static ConfigEntry<float> captiveMultiplier;
        public static ConfigEntry<string> captiveWeight;
        // BLURRY
        public static ConfigEntry<bool> isBlurry;
        public static ConfigEntry<float> blurryMultiplier;
        public static ConfigEntry<string> blurryWeight;
        public static ConfigEntry<float> blurryIntensity;
        // MUTE
        public static ConfigEntry<bool> isMute;
        public static ConfigEntry<float> muteMultiplier;
        public static ConfigEntry<string> muteWeight;
        // DEAFNESS
        public static ConfigEntry<bool> isDeafness;
        public static ConfigEntry<float> deafnessMultiplier;
        public static ConfigEntry<string> deafnessWeight;
        // ERRANT
        public static ConfigEntry<bool> isErrant;
        public static ConfigEntry<float> errantMultiplier;
        public static ConfigEntry<string> errantWeight;
        // PARALYSIS
        public static ConfigEntry<bool> isParalysis;
        public static ConfigEntry<float> paralysisMultiplier;
        public static ConfigEntry<string> paralysisWeight;
        public static ConfigEntry<float> paralysisTime;
        // SHADOW
        public static ConfigEntry<bool> isShadow;
        public static ConfigEntry<float> shadowMultiplier;
        public static ConfigEntry<string> shadowWeight;
        // SYNCHRONIZATION
        public static ConfigEntry<bool> isSynchronization;
        public static ConfigEntry<float> synchronizationMultiplier;
        public static ConfigEntry<string> synchronizationWeight;
        // DIMINUTIVE
        public static ConfigEntry<bool> isDiminutive;
        public static ConfigEntry<float> diminutiveMultiplier;
        public static ConfigEntry<string> diminutiveWeight;
        public static ConfigEntry<float> diminutiveSpeed;
        public static ConfigEntry<float> diminutiveGrab;
        // EXPLORATION
        public static ConfigEntry<bool> isExploration;
        public static ConfigEntry<float> explorationMultiplier;
        public static ConfigEntry<string> explorationWeight;
        public static ConfigEntry<float> explorationTime;
        // COMMUNICATION
        public static ConfigEntry<bool> isCommunication;
        public static ConfigEntry<float> communicationMultiplier;
        public static ConfigEntry<string> communicationWeight;
        public static ConfigEntry<int> communicationChrono;

        internal static void Load()
        {
            // GLOBAL
            globalChance = CursedScraps.configFile.Bind<string>("_Global_", "Chance", "default:30", "废料出现的总机会.\n这个值不能代替每个诅咒出现的机会;后者是在决定选择哪个诅咒的总体机会之后考虑的.");
            globalPrevent = CursedScraps.configFile.Bind<bool>("_Global_", "Preventing Settings Changes", true, "设置为false允许玩家在激活诅咒修改控制时可以更改设置.");
            // HIDE MECHANIC
            hidingMode = CursedScraps.configFile.Bind<string>("_Hiding mechanic_", "Mode", Constants.HIDING_COUNTER, "诅咒提示文本隐藏模式.\n" + Constants.HIDING_ALWAYS + " - 隐藏物品的诅咒提示.\n" + Constants.HIDING_NEVER + " - 显示物品的诅咒提示.\n" + Constants.HIDING_COUNTER + " - 捡到一定数量的非诅咒物品，就使用计数器隐藏诅咒.");
            hidingCounter = CursedScraps.configFile.Bind<int>("_Hiding mechanic_", "Counter", 10, " 在隐藏诅咒之前必须捡起的非诅咒物品的数量.\n每次捡到被诅咒的物品时，计数器都会重置.");
            // ANTI-CURSE PILLS
            isPills = CursedScraps.configFile.Bind<bool>(Constants.CURSE_PILLS, "Enable", true, Constants.CURSE_PILLS + " 是否启用?\n消耗品，可以移除玩家身上所有激活的诅咒。");
            pillsChance = CursedScraps.configFile.Bind<float>(Constants.CURSE_PILLS, "Chance", 15, "反诅咒药出现的总概率.\n这个值并不替代每个诅咒出现的概率,后者是在总概率确定之后再考虑的，用于决定选择哪个诅咒.");
            // INHIBITION
            isInhibition = CursedScraps.configFile.Bind<bool>(Constants.INHIBITION, "Enable", true, Constants.INHIBITION + " 诅咒是否启用?\n诅咒禁止玩家跳跃和下蹲.");
            inhibitionMultiplier = CursedScraps.configFile.Bind<float>(Constants.INHIBITION, "Multiplier", 2.7f, "带有 " + Constants.INHIBITION + " 诅咒的废料的价值乘数.");
            inhibitionWeight = CursedScraps.configFile.Bind<string>(Constants.INHIBITION, "Weight", "default:1,Experimentation:0", "带有 " + Constants.INHIBITION + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // CONFUSION
            isConfusion = CursedScraps.configFile.Bind<bool>(Constants.CONFUSION, "Enable", true, Constants.CONFUSION + " 诅咒是否启用?\n诅咒反转玩家的移动控制和跳跃/蹲伏按键的功能。.");
            confusionMultiplier = CursedScraps.configFile.Bind<float>(Constants.CONFUSION, "Multiplier", 2.6f, "带有 " + Constants.CONFUSION + " 诅咒的废料的价值乘数.");
            confusionWeight = CursedScraps.configFile.Bind<string>(Constants.CONFUSION, "Weight", "default:1", "带有 " + Constants.CONFUSION + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // CAPTIVE
            isCaptive = CursedScraps.configFile.Bind<bool>(Constants.CAPTIVE, "Enable", true, Constants.CAPTIVE + " 诅咒是否启用?\n诅咒废料在被玩家带回船只之前，是无法被丢弃或投掷的.");
            captiveMultiplier = CursedScraps.configFile.Bind<float>(Constants.CAPTIVE, "Multiplier", 1.8f, "带有 " + Constants.CAPTIVE + " 诅咒的废料的价值乘数.");
            captiveWeight = CursedScraps.configFile.Bind<string>(Constants.CAPTIVE, "Weight", "default:1", "带有 " + Constants.CAPTIVE + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // BLURRY
            isBlurry = CursedScraps.configFile.Bind<bool>(Constants.BLURRY, "Enable", true, Constants.BLURRY + " 诅咒是否启用?\n让玩家屏幕视野模糊");
            blurryMultiplier = CursedScraps.configFile.Bind<float>(Constants.BLURRY, "Multiplier", 2.4f, "带有 " + Constants.BLURRY + " 诅咒的废料的价值乘数.");
            blurryWeight = CursedScraps.configFile.Bind<string>(Constants.BLURRY, "Weight", "default:1", "带有 " + Constants.BLURRY + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            blurryIntensity = CursedScraps.configFile.Bind<float>(Constants.BLURRY, "Intensity", 1f, "Intensity of the " + Constants.BLURRY + " curse.");
            // MUTE
            isMute = CursedScraps.configFile.Bind<bool>(Constants.MUTE, "Enable", true, Constants.MUTE + " 诅咒是否启用?\n将玩家的麦克风静音.");
            muteMultiplier = CursedScraps.configFile.Bind<float>(Constants.MUTE, "Multiplier", 1.5f, "带有 " + Constants.MUTE + " 诅咒的废料的价值乘数.");
            muteWeight = CursedScraps.configFile.Bind<string>(Constants.MUTE, "Weight", "default:1", "带有 " + Constants.MUTE + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // DEAFNESS
            isDeafness = CursedScraps.configFile.Bind<bool>(Constants.DEAFNESS, "Enable", true, Constants.DEAFNESS + " 诅咒是否启用?\n让玩家听不见的语音.");
            deafnessMultiplier = CursedScraps.configFile.Bind<float>(Constants.DEAFNESS, "Multiplier", 2.7f, "带有 " + Constants.DEAFNESS + " 诅咒的废料的价值乘数.");
            deafnessWeight = CursedScraps.configFile.Bind<string>(Constants.DEAFNESS, "Weight", "default:1", "带有 " + Constants.DEAFNESS + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // ERRANT
            isErrant = CursedScraps.configFile.Bind<bool>(Constants.ERRANT, "Enable", true, Constants.ERRANT + " 诅咒是否启用?\n当玩家捡起或放下物品时，随机传送玩家.");
            errantMultiplier = CursedScraps.configFile.Bind<float>(Constants.ERRANT, "Multiplier", 2.5f, "带有 " + Constants.ERRANT + " 诅咒的废料的价值乘数.");
            errantWeight = CursedScraps.configFile.Bind<string>(Constants.ERRANT, "Weight", "default:1", "带有 " + Constants.ERRANT + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // PARALYSIS
            isParalysis = CursedScraps.configFile.Bind<bool>(Constants.PARALYSIS, "Enable", true, Constants.PARALYSIS + " 诅咒是否启用?\n扫描敌人时使玩家不能动几秒时间.");
            paralysisMultiplier = CursedScraps.configFile.Bind<float>(Constants.PARALYSIS, "Multiplier", 1.8f, "带有 " + Constants.PARALYSIS + " 诅咒的废料的价值乘数.");
            paralysisWeight = CursedScraps.configFile.Bind<string>(Constants.PARALYSIS, "Weight", "default:1", "带有 " + Constants.PARALYSIS + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            paralysisTime = CursedScraps.configFile.Bind<float>(Constants.PARALYSIS, "Time", 5f, "玩家不能动的时间,以秒为单位.");
            // SHADOW
            isShadow = CursedScraps.configFile.Bind<bool>(Constants.SHADOW, "Enable", true, Constants.SHADOW + " 诅咒是否启用?\n使所有敌人隐身(他们的声音仍然是活跃的)，扫描时会显示他们.");
            shadowMultiplier = CursedScraps.configFile.Bind<float>(Constants.SHADOW, "Multiplier", 2.4f, "带有 " + Constants.SHADOW + " 诅咒的废料的价值乘数.");
            shadowWeight = CursedScraps.configFile.Bind<string>(Constants.SHADOW, "Weight", "default:1", "带有 " + Constants.SHADOW + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // SYNCHRONIZATION
            isSynchronization = CursedScraps.configFile.Bind<bool>(Constants.SYNCHRONIZATION, "Enable", true, Constants.SYNCHRONIZATION + " 诅咒是否启用?\n废料被分成两部分，当这两部分被两个不同的玩家捡起时，反转他们的相机.");
            synchronizationMultiplier = CursedScraps.configFile.Bind<float>(Constants.SYNCHRONIZATION, "Multiplier", 7f, "带有 " + Constants.SYNCHRONIZATION + " 诅咒的废料的价值乘数.");
            synchronizationWeight = CursedScraps.configFile.Bind<string>(Constants.SYNCHRONIZATION, "Weight", "default:1", "带有 " + Constants.SYNCHRONIZATION + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            // DIMINUTIVE
            isDiminutive = CursedScraps.configFile.Bind<bool>(Constants.DIMINUTIVE, "Enable", true, Constants.DIMINUTIVE + " 诅咒是否启用?\n让玩家变大小.");
            diminutiveMultiplier = CursedScraps.configFile.Bind<float>(Constants.DIMINUTIVE, "Multiplier", 3f, "带有  " + Constants.DIMINUTIVE + " 诅咒的废料的价值乘数.");
            diminutiveWeight = CursedScraps.configFile.Bind<string>(Constants.DIMINUTIVE, "Weight", "default:1", "带有  " + Constants.DIMINUTIVE + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            diminutiveSpeed = CursedScraps.configFile.Bind<float>(Constants.DIMINUTIVE, "Speed", 2f, "玩家移动的速度分隔器,数值越高，玩家移动得越慢。");
            diminutiveGrab = CursedScraps.configFile.Bind<float>(Constants.DIMINUTIVE, "Grab", 4f, "对于玩家的距离抓取分隔器,数值越高，玩家能够从远处抓取到的东西就越少。");
            // EXPLORATION
            isExploration = CursedScraps.configFile.Bind<bool>(Constants.EXPLORATION, "Enable", true, Constants.EXPLORATION + " 诅咒是否启用?\n玩家只能使用特定的门来进入或离开工厂，其他所有的门都被阻止了。");
            explorationMultiplier = CursedScraps.configFile.Bind<float>(Constants.EXPLORATION, "Multiplier", 2.5f, "带有  " + Constants.EXPLORATION + " 诅咒的废料的价值乘数.");
            explorationWeight = CursedScraps.configFile.Bind<string>(Constants.EXPLORATION, "Weight", "default:1", "带有  " + Constants.EXPLORATION + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            explorationTime = CursedScraps.configFile.Bind<float>(Constants.EXPLORATION, "Time", 120f, "玩家可以扫描他们需要使用的出口门的持续时间，以秒为单位.");
            // COMMUNICATION
            isCommunication = CursedScraps.configFile.Bind<bool>(Constants.COMMUNICATION, "Enable", true, Constants.COMMUNICATION + " 诅咒是否启用?\n这个诅咒在两个阶段影响两个玩家。有关更多细节，请参阅README.");
            communicationMultiplier = CursedScraps.configFile.Bind<float>(Constants.COMMUNICATION, "Multiplier", 4f, "带有  " + Constants.COMMUNICATION + " 诅咒的废料的价值乘数.");
            communicationWeight = CursedScraps.configFile.Bind<string>(Constants.COMMUNICATION, "Weight", "default:1", "带有 " + Constants.COMMUNICATION + " 诅咒的废料的生成概率.\n可以根据月亮的名称和相应的值(moon:value)来调整这个概率, 每个键/值对之间用逗号分隔.");
            communicationChrono = CursedScraps.configFile.Bind<int>(Constants.COMMUNICATION, "Chrono", 120, "两名玩家返回飞船的时间限制.");
        }

        internal static List<CurseEffect> GetCurseEffectsFromConfig()
        {
            List<CurseEffect> curseEffects = new List<CurseEffect>();
            if (isInhibition.Value) curseEffects.Add(new CurseEffect(Constants.INHIBITION, inhibitionMultiplier.Value, inhibitionWeight.Value));
            if (isConfusion.Value) curseEffects.Add(new CurseEffect(Constants.CONFUSION, confusionMultiplier.Value, confusionWeight.Value));
            if (isCaptive.Value) curseEffects.Add(new CurseEffect(Constants.CAPTIVE, captiveMultiplier.Value, captiveWeight.Value));
            if (isBlurry.Value) curseEffects.Add(new CurseEffect(Constants.BLURRY, blurryMultiplier.Value, blurryWeight.Value));
            if (isMute.Value) curseEffects.Add(new CurseEffect(Constants.MUTE, muteMultiplier.Value, muteWeight.Value));
            if (isDeafness.Value) curseEffects.Add(new CurseEffect(Constants.DEAFNESS, deafnessMultiplier.Value, deafnessWeight.Value));
            if (isErrant.Value) curseEffects.Add(new CurseEffect(Constants.ERRANT, errantMultiplier.Value, errantWeight.Value));
            if (isParalysis.Value) curseEffects.Add(new CurseEffect(Constants.PARALYSIS, paralysisMultiplier.Value, paralysisWeight.Value));
            if (isShadow.Value) curseEffects.Add(new CurseEffect(Constants.SHADOW, shadowMultiplier.Value, shadowWeight.Value));
            if (isSynchronization.Value) curseEffects.Add(new CurseEffect(Constants.SYNCHRONIZATION, synchronizationMultiplier.Value, synchronizationWeight.Value));
            if (isDiminutive.Value) curseEffects.Add(new CurseEffect(Constants.DIMINUTIVE, diminutiveMultiplier.Value, diminutiveWeight.Value));
            if (isExploration.Value) curseEffects.Add(new CurseEffect(Constants.EXPLORATION, explorationMultiplier.Value, explorationWeight.Value));
            if (isCommunication.Value) curseEffects.Add(new CurseEffect(Constants.COMMUNICATION, communicationMultiplier.Value, communicationWeight.Value));

            return curseEffects;
        }
    }
}
