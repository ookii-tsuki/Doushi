using System.Collections.Generic;

namespace Doushi
{
    class DataHandler
    {
        public Dictionary<string, Dictionary<string, string[]>> ConjData { get; set; }
        public List<string> IrregularGodanRU;
        public List<string> GodanUSpecial;
        public List<string> NonKuru;

        internal DataHandler()
        {
            ConjData = new Dictionary<string, Dictionary<string, string[]>>();

            var ichidan = new Dictionary<string, string[]>();
            ichidan.Add("non-past", new string[] { "る", "ない" });
            ichidan.Add("non-past-polite", new string[] { "ます", "ません" });
            ichidan.Add("past", new string[] { "た", "なかった" });
            ichidan.Add("past-polite", new string[] { "ました", "ませんでした" });
            ichidan.Add("te-form", new string[] { "て", "なくて" });
            ichidan.Add("potential", new string[] { "られる", "られない" });
            ichidan.Add("passive", new string[] { "られる", "られない" });
            ichidan.Add("causative", new string[] { "させる", "させない" });
            ichidan.Add("causative-passive", new string[] { "させられる", "させられない" });
            ichidan.Add("imperative", new string[] { "ろ", "るな" });

            ConjData.Add("ichidan", ichidan);


            var godanU = new Dictionary<string, string[]>();
            godanU.Add("non-past", new string[] { "う", "わない" });
            godanU.Add("non-past-polite", new string[] { "います", "いません" });
            godanU.Add("past", new string[] { "った", "わなかった" });
            godanU.Add("past-polite", new string[] { "いました", "いませんでした" });
            godanU.Add("te-form", new string[] { "って", "わなくて" });
            godanU.Add("potential", new string[] { "える", "えない" });
            godanU.Add("passive", new string[] { "われる", "われない" });
            godanU.Add("causative", new string[] { "わせる", "わせない" });
            godanU.Add("causative-passive", new string[] { "わせられる", "わせられない" });
            godanU.Add("imperative", new string[] { "え", "うな" });

            ConjData.Add("godan_u", godanU);


            var godanKU = new Dictionary<string, string[]>();
            godanKU.Add("non-past", new string[] { "く", "かない" });
            godanKU.Add("non-past-polite", new string[] { "きます", "きません" });
            godanKU.Add("past", new string[] { "いた", "かなかった" });
            godanKU.Add("past-polite", new string[] { "きました", "きませんでした" });
            godanKU.Add("te-form", new string[] { "いて", "かなくて" });
            godanKU.Add("potential", new string[] { "ける", "けない" });
            godanKU.Add("passive", new string[] { "かれる", "かれない" });
            godanKU.Add("causative", new string[] { "かせる", "かせない" });
            godanKU.Add("causative-passive", new string[] { "かせられる", "かせられない" });
            godanKU.Add("imperative", new string[] { "け", "くな" });

            ConjData.Add("godan_ku", godanKU);


            var godanGU = new Dictionary<string, string[]>();
            godanGU.Add("non-past", new string[] { "ぐ", "がない" });
            godanGU.Add("non-past-polite", new string[] { "ぎます", "ぎません" });
            godanGU.Add("past", new string[] { "いだ", "がなかった" });
            godanGU.Add("past-polite", new string[] { "ぎました", "ぎませんでした" });
            godanGU.Add("te-form", new string[] { "いで", "がなくて" });
            godanGU.Add("potential", new string[] { "げる", "げない" });
            godanGU.Add("passive", new string[] { "がれる", "がれない" });
            godanGU.Add("causative", new string[] { "がせる", "がせない" });
            godanGU.Add("causative-passive", new string[] { "がせられる", "がせられない" });
            godanGU.Add("imperative", new string[] { "げ", "ぐな" });

            ConjData.Add("godan_gu", godanGU);


            var godanSU = new Dictionary<string, string[]>();
            godanSU.Add("non-past", new string[] { "す", "さない" });
            godanSU.Add("non-past-polite", new string[] { "します", "しません" });
            godanSU.Add("past", new string[] { "した", "さなかった" });
            godanSU.Add("past-polite", new string[] { "しました", "しませんでした" });
            godanSU.Add("te-form", new string[] { "して", "さなくて" });
            godanSU.Add("potential", new string[] { "せる", "せない" });
            godanSU.Add("passive", new string[] { "される", "されない" });
            godanSU.Add("causative", new string[] { "させる", "させない" });
            godanSU.Add("causative-passive", new string[] { "させられる", "させられない" });
            godanSU.Add("imperative", new string[] { "せ", "すな" });

            ConjData.Add("godan_su", godanSU);


            var godanTSU = new Dictionary<string, string[]>();
            godanTSU.Add("non-past", new string[] { "つ", "たない" });
            godanTSU.Add("non-past-polite", new string[] { "ちます", "ちません" });
            godanTSU.Add("past", new string[] { "った", "たなかった" });
            godanTSU.Add("past-polite", new string[] { "ちました", "ちませんでした" });
            godanTSU.Add("te-form", new string[] { "って", "たなくて" });
            godanTSU.Add("potential", new string[] { "てる", "てない" });
            godanTSU.Add("passive", new string[] { "たれる", "たれない" });
            godanTSU.Add("causative", new string[] { "たせる", "たせない" });
            godanTSU.Add("causative-passive", new string[] { "たせられる", "たせられない" });
            godanTSU.Add("imperative", new string[] { "て", "つな" });

            ConjData.Add("godan_tsu", godanTSU);


            var godanMU = new Dictionary<string, string[]>();
            godanMU.Add("non-past", new string[] { "む", "まない" });
            godanMU.Add("non-past-polite", new string[] { "みます", "みません" });
            godanMU.Add("past", new string[] { "んだ", "まなかった" });
            godanMU.Add("past-polite", new string[] { "みました", "みませんでした" });
            godanMU.Add("te-form", new string[] { "んで", "まなくて" });
            godanMU.Add("potential", new string[] { "める", "めない" });
            godanMU.Add("passive", new string[] { "まれる", "まれない" });
            godanMU.Add("causative", new string[] { "ませる", "ませない" });
            godanMU.Add("causative-passive", new string[] { "ませられる", "ませられない" });
            godanMU.Add("imperative", new string[] { "め", "むな" });

            ConjData.Add("godan_mu", godanMU);


            var godanBU = new Dictionary<string, string[]>();
            godanBU.Add("non-past", new string[] { "ぶ", "ばない" });
            godanBU.Add("non-past-polite", new string[] { "びます", "びません" });
            godanBU.Add("past", new string[] { "んだ", "ばなかった" });
            godanBU.Add("past-polite", new string[] { "びました", "びませんでした" });
            godanBU.Add("te-form", new string[] { "んで", "ばなくて" });
            godanBU.Add("potential", new string[] { "べる", "べない" });
            godanBU.Add("passive", new string[] { "ばれる", "ばれない" });
            godanBU.Add("causative", new string[] { "ばせる", "ばせない" });
            godanBU.Add("causative-passive", new string[] { "ばせられる", "ばせられない" });
            godanBU.Add("imperative", new string[] { "べ", "ぶな" });

            ConjData.Add("godan_bu", godanBU);


            var godanNU = new Dictionary<string, string[]>();
            godanNU.Add("non-past", new string[] { "ぬ", "なない" });
            godanNU.Add("non-past-polite", new string[] { "にます", "にません" });
            godanNU.Add("past", new string[] { "んだ", "ななかった" });
            godanNU.Add("past-polite", new string[] { "にました", "にませんでした" });
            godanNU.Add("te-form", new string[] { "んで", "ななくて" });
            godanNU.Add("potential", new string[] { "ねる", "ねない" });
            godanNU.Add("passive", new string[] { "なれる", "なれない" });
            godanNU.Add("causative", new string[] { "なせる", "なせない" });
            godanNU.Add("causative-passive", new string[] { "なせられる", "なせられない" });
            godanNU.Add("imperative", new string[] { "ね", "ぬな" });

            ConjData.Add("godan_nu", godanNU);


            var godanRU = new Dictionary<string, string[]>();
            godanRU.Add("non-past", new string[] { "る", "らない" });
            godanRU.Add("non-past-polite", new string[] { "ります", "りません" });
            godanRU.Add("past", new string[] { "った", "らなかった" });
            godanRU.Add("past-polite", new string[] { "りました", "りませんでした" });
            godanRU.Add("te-form", new string[] { "って", "らなくて" });
            godanRU.Add("potential", new string[] { "れる", "れない" });
            godanRU.Add("passive", new string[] { "られる", "られない" });
            godanRU.Add("causative", new string[] { "らせる", "らせない" });
            godanRU.Add("causative-passive", new string[] { "らせられる", "らせられない" });
            godanRU.Add("imperative", new string[] { "れ", "るな" });

            ConjData.Add("godan_ru", godanRU);


            var specialSURU = new Dictionary<string, string[]>();
            specialSURU.Add("non-past", new string[] { "す|る", "し|ない" });
            specialSURU.Add("non-past-polite", new string[] { "し|ます", "し|ません" });
            specialSURU.Add("past", new string[] { "し|た", "し|なかった" });
            specialSURU.Add("past-polite", new string[] { "し|ました", "し|ませんでした" });
            specialSURU.Add("te-form", new string[] { "し|て", "し|なくて" });
            specialSURU.Add("potential", new string[] { "できる", "できない" });
            specialSURU.Add("passive", new string[] { "さ|れる", "さ|れない" });
            specialSURU.Add("causative", new string[] { "さ|せる", "さ|せない" });
            specialSURU.Add("causative-passive", new string[] { "さ|せられる", "さ|せられない" });
            specialSURU.Add("imperative", new string[] { "し|ろ", "す|るな" });

            ConjData.Add("special_suru", specialSURU);


            var specialKURU = new Dictionary<string, string[]>();
            specialKURU.Add("non-past", new string[] { "く|る", "こ|ない" });
            specialKURU.Add("non-past-polite", new string[] { "き|ます", "き|ません" });
            specialKURU.Add("past", new string[] { "き|た", "こ|なかった" });
            specialKURU.Add("past-polite", new string[] { "き|ました", "き|ませんでした" });
            specialKURU.Add("te-form", new string[] { "き|て", "こ|なくて" });
            specialKURU.Add("potential", new string[] { "こ|られる", "こ|られない" });
            specialKURU.Add("passive", new string[] { "こ|られる", "こ|られない" });
            specialKURU.Add("causative", new string[] { "こ|させる", "こ|させない" });
            specialKURU.Add("causative-passive", new string[] { "こ|させられる", "こ|させられない" });
            specialKURU.Add("imperative", new string[] { "こ|い", "く|るな" });

            ConjData.Add("special_kuru", specialKURU);


            var GodanSpecialRU = new Dictionary<string, string[]>();
            GodanSpecialRU.Add("non-past", new string[] { "ある", "ない" });
            GodanSpecialRU.Add("non-past-polite", new string[] { "あります", "ありません" });
            GodanSpecialRU.Add("past", new string[] { "あった", "なかった" });
            GodanSpecialRU.Add("past-polite", new string[] { "ありました", "ありませんでした" });
            GodanSpecialRU.Add("te-form", new string[] { "あって", "なくて" });
            GodanSpecialRU.Add("potential", new string[] { "あれる", "あれない" });
            GodanSpecialRU.Add("passive", new string[] { "あられる", "あられない" });
            GodanSpecialRU.Add("causative", new string[] { "あらせる", "あらせない" });
            GodanSpecialRU.Add("causative-passive", new string[] { "あらせられる", "あらせられない" });
            GodanSpecialRU.Add("imperative", new string[] { "あれ", "あるな" });

            ConjData.Add("godan_special_ru", GodanSpecialRU);


            var GodanSpecialKU = new Dictionary<string, string[]>();
            GodanSpecialKU.Add("non-past", new string[] { "く", "かない" });
            GodanSpecialKU.Add("non-past-polite", new string[] { "きます", "きません" });
            GodanSpecialKU.Add("past", new string[] { "った", "かなかった" });
            GodanSpecialKU.Add("past-polite", new string[] { "きました", "きませんでした" });
            GodanSpecialKU.Add("te-form", new string[] { "って", "かなくて" });
            GodanSpecialKU.Add("potential", new string[] { "ける", "けない" });
            GodanSpecialKU.Add("passive", new string[] { "かれる", "かれない" });
            GodanSpecialKU.Add("causative", new string[] { "かせる", "かせない" });
            GodanSpecialKU.Add("causative-passive", new string[] { "かせられる", "かせられない" });
            GodanSpecialKU.Add("imperative", new string[] { "け", "くな" });

            ConjData.Add("godan_special_ku", GodanSpecialKU);


            var GodanSpecialU = new Dictionary<string, string[]>();
            GodanSpecialU.Add("non-past", new string[] { "う", "わない" });
            GodanSpecialU.Add("non-past-polite", new string[] { "います", "いません" });
            GodanSpecialU.Add("past", new string[] { "うた", "わなかった" });
            GodanSpecialU.Add("past-polite", new string[] { "いました", "いませんでした" });
            GodanSpecialU.Add("te-form", new string[] { "うて", "わなくて" });
            GodanSpecialU.Add("potential", new string[] { "える", "えない" });
            GodanSpecialU.Add("passive", new string[] { "われる", "われない" });
            GodanSpecialU.Add("causative", new string[] { "わせる", "わせない" });
            GodanSpecialU.Add("causative-passive", new string[] { "わさせられる", "わさせられない" });
            GodanSpecialU.Add("imperative", new string[] { "え", "うな" });

            ConjData.Add("godan_special_u", GodanSpecialU);


            IrregularGodanRU = new List<string>
            {
                "いびる",
                "くねる",
                "しくじる",
                "せびる",
                "突んのめる",
                "のめる",
                "やり切る",
                "阿る",
                "握る",
                "引きちぎる",
                "うかがい知る",
                "押し切る",
                "横切る",
                "火照る",
                "臥せる",
                "割り切る",
                "滑る",
                "噛み切る",
                "詰る",
                "牛耳る",
                "競る",
                "契る",
                "見くびる",
                "減る",
                "言い切る",
                "限る",
                "個人的に知る",
                "口火を切る",
                "口走る",
                "降りしきる",
                "困りきる",
                "才走る",
                "砕け散る",
                "散る",
                "斬る",
                "仕切る",
                "使い切る",
                "思い切る",
                "思い知る",
                "侍る",
                "持ち切る",
                "湿る",
                "湿気る",
                "煮えたぎる",
                "遮る",
                "借り切る",
                "弱り切る",
                "主導権を握る",
                "取り仕切る",
                "手を切る",
                "首を切る",
                "蹴る",
                "出切る",
                "焼き切る",
                "焦る",
                "照る",
                "乗っ切る",
                "乗り切る",
                "寝そべる",
                "振り切る",
                "吹き頻る",
                "澄み切る",
                "畝る",
                "生い茂る",
                "切る",
                "先走る",
                "千切る",
                "掻き毟る",
                "走る",
                "打ち切る",
                "駄弁る",
                "叩き切る",
                "耽る",
                "断ち切る",
                "値切る",
                "知る",
                "茶目る",
                "喋る",
                "張り切る",
                "電源を切る",
                "電話を切る",
                "踏み切る",
                "踏みにじる",
                "逃げ走る",
                "読みきる",
                "突っ走る",
                "捻る",
                "罵る",
                "買い切る",
                "迫る",
                "非行に走る",
                "飛び散る",
                "付き切る",
                "聞きかじる",
                "褒めちぎる",
                "茂る",
                "野次る",
                "裏切る",
                "立ち交じる",
                "冷え切る",
                "練る",
                "弄る",
                "剪み切る",
                "剪る",
                "ケチる",
                "嘲る",
                "抓る",
                "ねじ切る",
                "毟る",
                "漲る",
                "翔る",
                "軋る",
                "迸る",
                "入り混じる",
                "陰る",
                "区切る",
                "締め切る",
                "擦り切る",
                "曲がりくねる",
                "混じる",
                "分かりきる",
                "齧る",
                "捩る",
                "見限る",
                "腹が減る",
                "シラを切る",
                "見知る",
                "突っ切る",
                "謗る",
                "口が滑る",
                "苦り切る",
                "血走る",
                "読みふける",
                "間切る",
                "見切る",
                "詰め切る",
                "売り切る",
                "成り切る",
                "疲れきる",
                "出し切る",
                "甲走る",
                "逃げ切る",
                "息せき切る",
                "貸し切る",
                "愚痴る",
                "天翔る",
                "掻き切る",
                "立て切る",
                "食い切る",
                "食い齧る",
                "味わい知る",
                "枝を剪る",
                "縁を切る",
                "女の味を知る",
                "角に切る",
                "切符を切る",
                "極端に走る",
                "木を伐る",
                "句を切る",
                "権力を握る",
                "光線を遮る",
                "左翼に走る",
                "勝敗の鍵を握る",
                "寿司を握る",
                "想を練る",
                "大衆に阿る",
                "飛び翔る",
                "波を切る",
                "話を遮る",
                "日を限る",
                "封を切る",
                "武を練る",
                "見得を切る",
                "虫唾が走る",
                "テープを切る",
                "磨り減る",
                "ぶっ千切る",
                "滾る",
                "ちょん切る",
                "穿る",
                "封切る",
                "猛る",
                "滑る",
                "髪を切る",
                "手刀を切る",
                "頻る",
                "気が散る",
                "おちょくる",
                "パシる",
                "掻っ穿る",
                "啖呵を切る",
                "くっちゃべる",
                "ラリる",
                "鞘走る",
                "とちる",
                "親のすねをかじる",
                "ビニる",
                "ビビる",
                "大見得を切る",
                "風を切る",
                "肩で風を切る",
                "聞き知る",
                "過ぎる",
                "截る",
                "伐る",
                "躙る",
                "拒否る",
                "手に汗を握る",
                "相知る",
                "十字を切る",
                "食いちぎる",
                "利に走る",
                "挵る",
                "赤子の手をひねる",
                "赤子の腕をひねる",
                "ドジる",
                "過ちを観て斯に仁を知る",
                "守りきる",
                "払いきる",
                "肉が減る",
                "お腹が減る",
                "拉致る",
                "鑽る",
                "朝日る",
                "自腹を切る",
                "スタートを切る",
                "火蓋を切る",
                "首をひねる",
                "席を蹴る",
                "抉る",
                "抉る",
                "一を聞いて十を知る",
                "パーティションを切る",
                "手がすべる",
                "身銭を切る",
                "恥を知る",
                "財布の紐を握る",
                "放る",
                "メンチを切る",
                "堰を切る",
                "ちびる",
                "乾ききる",
                "頭を捻る",
                "ぶった切る",
                "捥る",
                "縊る",
                "取り切る",
                "寄り切る",
                "掻っ切る",
                "シャッターを切る",
                "桜散る",
                "舵を切る",
                "肌で知る",
                "言葉をもじる",
                "感情に走る",
                "鳴き頻る",
                "泣き頻る",
                "哮る",
                "魂消る",
                "首切る",
                "いちびる",
                "政権を握る",
                "鍵を握る",
                "情けを知る",
                "幕を切る",
                "天命を知る",
                "考え事にふける",
                "考えにふける",
                "ひた走る",
                "噛み千切る",
                "札片を切る",
                "吹っ切る",
                "ぶっ切る",
                "舞い散る",
                "煮切る",
                "仁義を切る",
                "屁をひる",
                "脂ぎる",
                "裏目る",
                "脛をかじる",
                "スイッチを切る",
                "拳を握る",
                "入り切る",
                "先頭を切る",
                "身をよじる",
                "あずかり知る",
                "思いふける",
                "引き切る",
                "文字る",
                "信じきる",
                "登りきる",
                "言葉を切る",
                "空を切る",
                "頭をよぎる",
                "脳裏をよぎる",
                "神る",
                "ぎる",
                "息を切る",
                "期限を切る",
                "取り過ぎる",
                "心が洗われる",
                "口を切る",
                "プロってる",
                "イキる",
                "肉を切らせて骨を切る",
                "パチる",
                "ガチる",
                "簸る",
                "功を焦る",
                "弱みを握る",
                "ハンドルを握る",
                "水を切る",
                "策を練る",
                "手に汗握る",
                "錬る",
                "邌る",
                "盛れる",
                "ひっくり返る",
                "陥る",
                "帰る",
                "冴え返る",
                "参る",
                "自縄自縛に陥る",
                "煮え返る",
                "若返る",
                "取って参る",
                "出っ張る",
                "寝返る",
                "振り返る",
                "生き返る",
                "炒る",
                "跳ね返る",
                "当てこする",
                "ふんぞり返る",
                "堂にいる",
                "反り返る",
                "覆る",
                "沸き返る",
                "返る",
                "翻る",
                "要る",
                "裏返る",
                "立ち返る",
                "噎せ返る",
                "孵る",
                "端折る",
                "揺する",
                "あきれ返る",
                "折れ返る",
                "引っ張る",
                "蘇る",
                "突っ張る",
                "でんぐり返る",
                "持ち帰る",
                "静まり返る",
                "見返る",
                "割れ返る",
                "逃げ帰る",
                "煮えくり返る",
                "誤りに陥る",
                "風に翻る",
                "土に帰る",
                "罪に陥る",
                "良い引きがある",
                "デニる",
                "ポシャる",
                "アジる",
                "そっくり返る",
                "テンパる",
                "ヤニる",
                "チェキる",
                "打っちゃる",
                "納まり返る",
                "連れ帰る",
                "コピる",
                "胡麻をする",
                "ナビる",
                "カフェる",
                "ゴチる",
                "チキる",
                "足を引っ張る",
                "我に返る",
                "溢れかえる",
                "沒る",
                "はらわたが煮えくり返る",
                "ガシる",
                "原点に帰る",
                "オケる",
                "ポニョる",
                "起き返る",
                "アピる",
                "鼻をすする",
                "欲の皮が突っ張る",
                "ジェラシる",
                "ステる",
                "ハミる",
                "しょげ返る",
                "火病る",
                "反りくり返る",
                "ウィキる",
                "だきょる",
                "窮地に陥る",
                "タヒる",
                "ブヒる",
                "奇想天外より来る",
                "ポチる",
                "撫でさする",
                "ボミる",
                "放っぽる",
                "タピる"
            };
            GodanUSpecial = new List<string>
            {
                "請う",
                "許しを請う",
                "教えを請う",
                "与え給う",
                "給う",
                "揺蕩う",
                "問う"
            };
            NonKuru = new List<string> 
            {
                "引ったくる",
                "押しまくる",
                "泣きじゃくる",
                "書きまくる",
                "吹きまくる",
                "切りまくる",
                "締めくくる",
                "黙りこくる",
                "打ちまくる",
                "捻くる",
                "追いまくる",
                "言いまくる",
                "ちくる",
                "歌いまくる",
                "弄くる",
                "塗りたくる",
                "のたくる",
                "ぬたくる",
                "おちょくる",
                "もくる",
                "しくる",
                "木で鼻をくくる",
                "尻をまくる",
                "重箱の隅をほじくる",
                "ふんだくる",
                "重箱の隅をようじでほじくる",
                "たくる",
                "喋くる",
                "打ったくる",
                "喋りまくる",
                "顎をしゃくる",
                "押しこくる",
                "新しいページをめくる",
                "鬨をつくる",
                "奇想天外より来る"
            };
        }
    }
}
