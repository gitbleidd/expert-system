using ExpertSystemShellDomain.Entities;

namespace ExpertSystemShellDomain;

public static class InitKnowledgeBase
{
    public static readonly Domain RUSBAL_domain;
    public static readonly Domain IZLOJ_domain;
    public static readonly Domain WRTLVL_domain;
    public static readonly Domain LITBAL_domain;
    public static readonly Domain READSPD_domain;
    public static readonly Domain BOOKCNT_domain;
    public static readonly Domain READLVL_domain;
    public static readonly Domain RUSLVL_domain;
    public static readonly Domain LNGCNT_domain;
    public static readonly Domain LNGBEG_domain;
    public static readonly Domain LNGDROP_domain;
    public static readonly Domain MULTLVL_domain;
    public static readonly Domain TALKEXP_domain;
    public static readonly Domain FRNLIT_domain;
    public static readonly Domain MSCUND_domain;
    public static readonly Domain LNGEXP_domain;
    public static readonly Domain FRNLLVL_domain;
    public static readonly Domain LLVL_domain;
    public static readonly Domain SELFEDU_domain;
    public static readonly Domain FRNCULT_domain;
    public static readonly Domain MOTLVL_domain;
    public static readonly Domain DLGHARD_domain;
    public static readonly Domain NERVOUS_domain;
    public static readonly Domain EXPROMT_domain;
    public static readonly Domain LNGBAR_domain;
    public static readonly Domain PSYBAR_domain;
    public static readonly Domain SEX_domain;
    public static readonly Domain AGE_domain;
    public static readonly Domain GENAGE_domain;
    public static readonly Domain POEMLVL_domain;
    public static readonly Domain FACTLVL_domain;
    public static readonly Domain DIARY_domain;
    public static readonly Domain MEMLVL_domain;
    public static readonly Domain VOCAL_domain;
    public static readonly Domain HEARING_domain;
    public static readonly Domain MSCLVL_domain;
    public static readonly Domain QLTLVL_domain;
    public static readonly Domain INDLVL_domain;
    public static readonly Domain PREDLVL_domain;
    
    public static readonly Variable RUSBAL_variable;
    public static readonly Variable IZLOJ_variable;
    public static readonly Variable WRTLVL_variable;
    public static readonly Variable LITBAL_variable;
    public static readonly Variable READSPD_variable;
    public static readonly Variable BOOKCNT_variable;
    public static readonly Variable READLVL_variable;
    public static readonly Variable RUSLVL_variable;
    public static readonly Variable LNGCNT_variable;
    public static readonly Variable LNGBEG_variable;
    public static readonly Variable LNGDROP_variable;
    public static readonly Variable MULTLVL_variable;
    public static readonly Variable TALKEXP_variable;
    public static readonly Variable FRNLIT_variable;
    public static readonly Variable MSCUND_variable;
    public static readonly Variable LNGEXP_variable;
    public static readonly Variable FRNLLVL_variable;
    public static readonly Variable LLVL_variable;
    public static readonly Variable SELFEDU_variable;
    public static readonly Variable FRNCULT_variable;
    public static readonly Variable MOTLVL_variable;
    public static readonly Variable DLGHARD_variable;
    public static readonly Variable NERVOUS_variable;
    public static readonly Variable EXPROMT_variable;
    public static readonly Variable LNGBAR_variable;
    public static readonly Variable PSYBAR_variable;
    public static readonly Variable SEX_variable;
    public static readonly Variable AGE_variable;
    public static readonly Variable GENAGE_variable;
    public static readonly Variable POEMLVL_variable;
    public static readonly Variable FACTLVL_variable;
    public static readonly Variable DIARY_variable;
    public static readonly Variable MEMLVL_variable;
    public static readonly Variable VOCAL_variable;
    public static readonly Variable HEARING_variable;
    public static readonly Variable MSCLVL_variable;
    public static readonly Variable QLTLVL_variable;
    public static readonly Variable INDLVL_variable;
    public static readonly Variable PREDLVL_variable;
    
    public static KnowledgeBase KnowledgeBase { get; }
    
    static InitKnowledgeBase()
    {
        KnowledgeBase = new KnowledgeBase();
        
        RUSBAL_domain = new Domain("Ср. бал по русскому языку в школе");
        KnowledgeBase.Domains.Add(RUSBAL_domain);
        RUSBAL_domain.Values.Add(new DomainValue("Менее 3.5"));
        RUSBAL_domain.Values.Add(new DomainValue("От 3.5 до 4.5"));
        RUSBAL_domain.Values.Add(new DomainValue("Более 4.5"));
        
        IZLOJ_domain = new Domain("Трудности с написанием изложений в школе");
        KnowledgeBase.Domains.Add(IZLOJ_domain);
        IZLOJ_domain.Values.Add(new DomainValue("Нет"));
        IZLOJ_domain.Values.Add(new DomainValue("Да"));
        
        WRTLVL_domain = new Domain("Уровень аудирования и письма");
        KnowledgeBase.Domains.Add(WRTLVL_domain);
        WRTLVL_domain.Values.Add(new DomainValue("Низкий"));
        WRTLVL_domain.Values.Add(new DomainValue("Средний"));
        WRTLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        LITBAL_domain = new Domain("Ср. бал по литературе в школе");
        KnowledgeBase.Domains.Add(LITBAL_domain);
        LITBAL_domain.Values.Add(new DomainValue("Менее 4"));
        LITBAL_domain.Values.Add(new DomainValue("Более 4"));
        
        READSPD_domain = new Domain("Скорость чтения");
        KnowledgeBase.Domains.Add(READSPD_domain);
        READSPD_domain.Values.Add(new DomainValue("Обычная"));
        READSPD_domain.Values.Add(new DomainValue("Высокая"));
        
        BOOKCNT_domain = new Domain("Книг прочитано за последние полгода");
        KnowledgeBase.Domains.Add(BOOKCNT_domain);
        BOOKCNT_domain.Values.Add(new DomainValue("Ни одной"));
        BOOKCNT_domain.Values.Add(new DomainValue("Одну"));
        BOOKCNT_domain.Values.Add(new DomainValue("От 2 до 4"));
        BOOKCNT_domain.Values.Add(new DomainValue("Более 4"));
        
        READLVL_domain = new Domain("Уровень чтения и речи");
        KnowledgeBase.Domains.Add(READLVL_domain);
        READLVL_domain.Values.Add(new DomainValue("Низкий"));
        READLVL_domain.Values.Add(new DomainValue("Средний"));
        READLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        RUSLVL_domain = new Domain("Уровень владения родным языком");
        KnowledgeBase.Domains.Add(RUSLVL_domain);
        RUSLVL_domain.Values.Add(new DomainValue("Низкий"));
        RUSLVL_domain.Values.Add(new DomainValue("Средний"));
        RUSLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        LNGCNT_domain = new Domain("Кол-во иностранных языков, которыми владеете в той или иной степени");
        KnowledgeBase.Domains.Add(LNGCNT_domain);
        LNGCNT_domain.Values.Add(new DomainValue("Ни одного"));
        LNGCNT_domain.Values.Add(new DomainValue("Один"));
        LNGCNT_domain.Values.Add(new DomainValue("Более одного"));
        
        LNGBEG_domain = new Domain("Возрасте начала изуч. иностранных языков");
        KnowledgeBase.Domains.Add(LNGBEG_domain);
        LNGBEG_domain.Values.Add(new DomainValue("После 14 лет"));
        LNGBEG_domain.Values.Add(new DomainValue("До 14 лет"));
        
        LNGDROP_domain = new Domain("Прерыв в обучении иностранному языку");
        KnowledgeBase.Domains.Add(LNGDROP_domain);
        LNGDROP_domain.Values.Add(new DomainValue("Нет"));
        LNGDROP_domain.Values.Add(new DomainValue("Да"));
        
        MULTLVL_domain = new Domain("Уровень усвоения нескольких языков");
        KnowledgeBase.Domains.Add(MULTLVL_domain);
        MULTLVL_domain.Values.Add(new DomainValue("Низкий"));
        MULTLVL_domain.Values.Add(new DomainValue("Средний"));
        MULTLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        TALKEXP_domain = new Domain("Опыт общения с носителями языка");
        KnowledgeBase.Domains.Add(TALKEXP_domain);
        TALKEXP_domain.Values.Add(new DomainValue("Нет"));
        TALKEXP_domain.Values.Add(new DomainValue("Во время поездки"));
        TALKEXP_domain.Values.Add(new DomainValue("Жил в стране"));
        
        FRNLIT_domain = new Domain("Приходилось ли читать литературу на иностранном языке");
        KnowledgeBase.Domains.Add(FRNLIT_domain);
        FRNLIT_domain.Values.Add(new DomainValue("Нет"));
        FRNLIT_domain.Values.Add(new DomainValue("Да"));
        
        MSCUND_domain = new Domain("Понимание текста песен на иностранном языке");
        KnowledgeBase.Domains.Add(MSCUND_domain);
        MSCUND_domain.Values.Add(new DomainValue("Нет"));
        MSCUND_domain.Values.Add(new DomainValue("Отчасти"));
        MSCUND_domain.Values.Add(new DomainValue("Большая часть понятна"));
        
        LNGEXP_domain = new Domain("Опыт применения ин. яз.");
        KnowledgeBase.Domains.Add(LNGEXP_domain);
        LNGEXP_domain.Values.Add(new DomainValue("Низкий"));
        LNGEXP_domain.Values.Add(new DomainValue("Средний"));
        LNGEXP_domain.Values.Add(new DomainValue("Высокий"));
        
        FRNLLVL_domain = new Domain("Уровень владения иностранными языками");
        KnowledgeBase.Domains.Add(FRNLLVL_domain);
        FRNLLVL_domain.Values.Add(new DomainValue("Нет опыта"));
        FRNLLVL_domain.Values.Add(new DomainValue("Низкий"));
        FRNLLVL_domain.Values.Add(new DomainValue("Средний"));
        FRNLLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        LLVL_domain = new Domain("Уровень языковых способностей");
        KnowledgeBase.Domains.Add(LLVL_domain);
        LLVL_domain.Values.Add(new DomainValue("Низкий"));
        LLVL_domain.Values.Add(new DomainValue("Средний"));
        LLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        SELFEDU_domain = new Domain("Можете ли вы потратить дополнительные часы на самостоятельное изучение чего-либо?");
        KnowledgeBase.Domains.Add(SELFEDU_domain);
        SELFEDU_domain.Values.Add(new DomainValue("Нет"));
        SELFEDU_domain.Values.Add(new DomainValue("Да"));
        
        FRNCULT_domain = new Domain("Проявляли ли вы когда-нибудь интерес к иностранным культурам?");
        KnowledgeBase.Domains.Add(FRNCULT_domain);
        FRNCULT_domain.Values.Add(new DomainValue("Нет"));
        FRNCULT_domain.Values.Add(new DomainValue("Да"));
        
        MOTLVL_domain = new Domain("Уровень мотивации");
        KnowledgeBase.Domains.Add(MOTLVL_domain);
        MOTLVL_domain.Values.Add(new DomainValue("Низкий"));
        MOTLVL_domain.Values.Add(new DomainValue("Средний"));
        MOTLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        DLGHARD_domain = new Domain("Испытываете ли вы трудности с тем, чтобы начать диалог?");
        KnowledgeBase.Domains.Add(DLGHARD_domain);
        DLGHARD_domain.Values.Add(new DomainValue("Нет"));
        DLGHARD_domain.Values.Add(new DomainValue("Да"));
        
        NERVOUS_domain = new Domain("Испытываете ли вы неуверенность, волнение, разговаривая на иностранном языке?");
        KnowledgeBase.Domains.Add(NERVOUS_domain);
        NERVOUS_domain.Values.Add(new DomainValue("Нет"));
        NERVOUS_domain.Values.Add(new DomainValue("Да"));
        
        EXPROMT_domain = new Domain("На сколько для вас сложно выступить экспромтом?");
        KnowledgeBase.Domains.Add(EXPROMT_domain);
        EXPROMT_domain.Values.Add(new DomainValue("Не могу"));
        EXPROMT_domain.Values.Add(new DomainValue("Сложно"));
        EXPROMT_domain.Values.Add(new DomainValue("Не испытываю трудностей"));
        
        LNGBAR_domain = new Domain("Уровень языкового барьера");
        KnowledgeBase.Domains.Add(LNGBAR_domain);
        LNGBAR_domain.Values.Add(new DomainValue("Низкий"));
        LNGBAR_domain.Values.Add(new DomainValue("Средний"));
        LNGBAR_domain.Values.Add(new DomainValue("Высокий"));
        
        PSYBAR_domain = new Domain("Уровень психологического барьера");
        KnowledgeBase.Domains.Add(PSYBAR_domain);
        PSYBAR_domain.Values.Add(new DomainValue("Низкий"));
        PSYBAR_domain.Values.Add(new DomainValue("Средний"));
        PSYBAR_domain.Values.Add(new DomainValue("Высокий"));
        
        SEX_domain = new Domain("Пол");
        KnowledgeBase.Domains.Add(SEX_domain);
        SEX_domain.Values.Add(new DomainValue("Мужчина"));
        SEX_domain.Values.Add(new DomainValue("Женщина"));
        
        AGE_domain = new Domain("Возраст");
        KnowledgeBase.Domains.Add(AGE_domain);
        AGE_domain.Values.Add(new DomainValue("Старше 30"));
        AGE_domain.Values.Add(new DomainValue("От 18 до 30"));
        AGE_domain.Values.Add(new DomainValue("Менее 18"));
        
        GENAGE_domain = new Domain("Степень гендерно-возрастного расположения к языкам");
        KnowledgeBase.Domains.Add(GENAGE_domain);
        GENAGE_domain.Values.Add(new DomainValue("Нормальная"));
        GENAGE_domain.Values.Add(new DomainValue("Повышенная"));
        
        POEMLVL_domain = new Domain("Хорошо ли вы запоминаете стихи, песни?");
        KnowledgeBase.Domains.Add(POEMLVL_domain);
        POEMLVL_domain.Values.Add(new DomainValue("Плохо"));
        POEMLVL_domain.Values.Add(new DomainValue("Хорошо"));
        
        FACTLVL_domain = new Domain("Хорошо ли вы запоминаете числа, факты?");
        KnowledgeBase.Domains.Add(FACTLVL_domain);
        FACTLVL_domain.Values.Add(new DomainValue("Плохо"));
        FACTLVL_domain.Values.Add(new DomainValue("Хорошо"));
        
        DIARY_domain = new Domain("Ведете ли вы дневник напоминаний?");
        KnowledgeBase.Domains.Add(DIARY_domain);
        DIARY_domain.Values.Add(new DomainValue("Нет"));
        DIARY_domain.Values.Add(new DomainValue("Да"));
        
        MEMLVL_domain = new Domain("Уровень памяти");
        KnowledgeBase.Domains.Add(MEMLVL_domain);
        MEMLVL_domain.Values.Add(new DomainValue("Низкий"));
        MEMLVL_domain.Values.Add(new DomainValue("Средний"));
        MEMLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        VOCAL_domain = new Domain("Имеете ли вы вокальные способности?");
        KnowledgeBase.Domains.Add(VOCAL_domain);
        VOCAL_domain.Values.Add(new DomainValue("Нет"));
        VOCAL_domain.Values.Add(new DomainValue("Да"));
        VOCAL_domain.Values.Add(new DomainValue(""));
        
        HEARING_domain = new Domain("Можете ли вы сказать, что обладаете музыкальным слухом?");
        KnowledgeBase.Domains.Add(HEARING_domain);
        HEARING_domain.Values.Add(new DomainValue("Нет"));
        HEARING_domain.Values.Add(new DomainValue("Да"));
        
        MSCLVL_domain = new Domain("Музыкальные способности");
        KnowledgeBase.Domains.Add(MSCLVL_domain);
        MSCLVL_domain.Values.Add(new DomainValue("Нет"));
        MSCLVL_domain.Values.Add(new DomainValue("Есть"));
        
        QLTLVL_domain = new Domain("Уровень индивидуальных качеств, влияющих на способности к иностранным языкам");
        KnowledgeBase.Domains.Add(QLTLVL_domain);
        QLTLVL_domain.Values.Add(new DomainValue("Низкий"));
        QLTLVL_domain.Values.Add(new DomainValue("Средний"));
        QLTLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        INDLVL_domain = new Domain("Уровень индивидуальных способностей");
        KnowledgeBase.Domains.Add(INDLVL_domain);
        INDLVL_domain.Values.Add(new DomainValue("Низкий"));
        INDLVL_domain.Values.Add(new DomainValue("Средний"));
        INDLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        PREDLVL_domain = new Domain("Уровень предрасположенности к изучению иностранных языков");
        KnowledgeBase.Domains.Add(PREDLVL_domain);
        PREDLVL_domain.Values.Add(new DomainValue("Низкий"));
        PREDLVL_domain.Values.Add(new DomainValue("Средний"));
        PREDLVL_domain.Values.Add(new DomainValue("Высокий"));
        
        // RUSBAL_variable = new Variable("Ср. балл по русскому языку (rusbal)", RUSBAL_domain, VarType.Requested, "Ваш ср. бал по русскому языку в школе?");
        // IZLOJ_variable = new Variable("Трудности написания изложений (izloj)", IZLOJ_domain, VarType.Requested, "У вас были трудности с написанием изложений в школе?");
        // WRTLVL_variable = new Variable("Уровень аудирования и письма (wrtlvl)", WRTLVL_domain, VarType.InferredRequested, "");
        // LITBAL_variable = new Variable("Ср. балл по литературе (litbal)", LITBAL_domain, VarType.Requested, "Ваш ср. бал по литературе в школе?");
        // READSPD_variable = new Variable("Скорость чтения (readspd)", READSPD_domain, VarType.Requested, "Как вы оцениваете вашу скорость чтения?");
        // BOOKCNT_variable = new Variable("Кол-во прочитанных книг (bookcnt)", BOOKCNT_domain, VarType.Requested, "Сколько книг вы прочитали за последние полгода?");
        // READLVL_variable = new Variable("Уровень чтения и речи (readlvl)", READLVL_domain, VarType.InferredRequested, "");
        // RUSLVL_variable = new Variable("Уровень владения родным языком (ruslvl)", RUSLVL_domain, VarType.InferredRequested, "");
        // LNGCNT_variable = new Variable("Кол-во изученных иностранных (lngcnt)", LNGCNT_domain, VarType.Requested, "Кол-во иностранных языков, которыми вы владеете?");
        // LNGBEG_variable = new Variable("Возраст начала изучения ин. яз. (lngbeg)", LNGBEG_domain, VarType.Requested, "В каком возрасте вы изучали иностранный язык?");
        // LNGDROP_variable = new Variable("Прерывание обучения ин. яз. (lngdrop)", LNGDROP_domain, VarType.Requested, "Прерывали ли вы обучение иностранному языку?");
        // MULTLVL_variable = new Variable("Уровень усвоения нескольких языков  (multlvl)", MULTLVL_domain, VarType.InferredRequested, "");
        // TALKEXP_variable = new Variable("Опыт общения с носителями (talkexp)", TALKEXP_domain, VarType.Requested, "Имеете ли вы опыт общения с носителями языка?");
        // FRNLIT_variable = new Variable("Опыт чтения иностранной литературы (frnlit)", FRNLIT_domain, VarType.Requested, "Приходилось ли читать литературу на ин. языке?");
        // MSCUND_variable = new Variable("Уровень понимания иностранных песен (mscund)", MSCUND_domain, VarType.Requested, "Можете ли вы понимать текст песен на ин. языке?");
        // LNGEXP_variable = new Variable("Опыт применения ин. яз. (lngexp)", LNGEXP_domain, VarType.InferredRequested, "");
        // FRNLLVL_variable = new Variable("Уровень владения иностранными языками (frnllvl)", FRNLLVL_domain, VarType.InferredRequested, "");
        // LLVL_variable = new Variable("Уровень языковых способностей (llvl)", LLVL_domain, VarType.InferredRequested, "");
        // SELFEDU_variable = new Variable("Самообучаемость (selfedu)", SELFEDU_domain, VarType.Requested, "Можете потратить время на самост. изучение чего-либо?");
        // FRNCULT_variable = new Variable("Интерес к иностранным культурам (frncult)", FRNCULT_domain, VarType.Requested, "Проявляли ли вы интерес к иностранным культурам?");
        // MOTLVL_variable = new Variable("Уровень мотивации (motlvl)", MOTLVL_domain, VarType.InferredRequested, "");
        // DLGHARD_variable = new Variable("Трудности с началом диалога (dlghard)", DLGHARD_domain, VarType.Requested, "Испытываете ли вы трудности с тем, чтобы начать диалог?");
        // NERVOUS_variable = new Variable("Волнение при общении на ин. яз. (nervous)", NERVOUS_domain, VarType.Requested, "Испытываете ли вы волнение, разговаривая на ин.языке?");
        // EXPROMT_variable = new Variable("Уровень экспромта (expromt)", EXPROMT_domain, VarType.Requested, "На сколько для вас сложно выступить экспромтом?");
        // LNGBAR_variable = new Variable("Уровень языкового барьера (lngbar)", LNGBAR_domain, VarType.InferredRequested, "");
        // PSYBAR_variable = new Variable("Уровень психологического барьера (psybar)", PSYBAR_domain, VarType.InferredRequested, "");
        // SEX_variable = new Variable("Пол (sex)", SEX_domain, VarType.Requested, "Ваш пол?");
        // AGE_variable = new Variable("Возраст (age)", AGE_domain, VarType.Requested, "Ваш возраст?");
        // GENAGE_variable = new Variable("Степень гендерно-возрастного расположения к языкам (genage)", GENAGE_domain, VarType.InferredRequested, "");
        // POEMLVL_variable = new Variable("Память на стихи, песни (poemlvl)", POEMLVL_domain, VarType.Requested, "Хорошо ли вы запоминаете стихи, песни?");
        // FACTLVL_variable = new Variable("Память на числа, факты (factlvl)", FACTLVL_domain, VarType.Requested, "Хорошо ли вы запоминаете числа, факты?");
        // DIARY_variable = new Variable("Дневник напоминаний (diary)", DIARY_domain, VarType.Requested, "Ведете ли вы дневник напоминаний?");
        // MEMLVL_variable = new Variable("Уровень памяти (memlvl)", MEMLVL_domain, VarType.InferredRequested, "");
        // VOCAL_variable = new Variable("Вокал (vocal)", VOCAL_domain, VarType.Requested, "Имеете ли вы вокальные способности?");
        // HEARING_variable = new Variable("Музыкальный слух (hearing)", HEARING_domain, VarType.Requested, "Можете ли сказать, что обладаете музыкальным слухом?");
        // MSCLVL_variable = new Variable("Музыкальные способности (msclvl)", MSCLVL_domain, VarType.InferredRequested, "");
        // QLTLVL_variable = new Variable("Уровень индивидуальных качеств (qltlvl)", QLTLVL_domain, VarType.InferredRequested, "");
        // INDLVL_variable = new Variable("Уровень индивидуальных способностей (indlvl)", INDLVL_domain, VarType.InferredRequested, "");
        // PREDLVL_variable = new Variable("Уровень предрасположенности к изучению ин. яз. (predlvl)", PREDLVL_domain, VarType.Inferred, "");
        
        RUSBAL_variable = new Variable("Ср. балл по русскому языку", RUSBAL_domain, VarType.Requested, "Ваш ср. бал по русскому языку в школе?");
        IZLOJ_variable = new Variable("Трудности написания изложений", IZLOJ_domain, VarType.Requested, "У вас были трудности с написанием изложений в школе?");
        WRTLVL_variable = new Variable("Уровень аудирования и письма", WRTLVL_domain, VarType.InferredRequested, "");
        LITBAL_variable = new Variable("Ср. балл по литературе", LITBAL_domain, VarType.Requested, "Ваш ср. бал по литературе в школе?");
        READSPD_variable = new Variable("Скорость чтения", READSPD_domain, VarType.Requested, "Как вы оцениваете вашу скорость чтения?");
        BOOKCNT_variable = new Variable("Кол-во прочитанных книг", BOOKCNT_domain, VarType.Requested, "Сколько книг вы прочитали за последние полгода?");
        READLVL_variable = new Variable("Уровень чтения и речи", READLVL_domain, VarType.InferredRequested, "");
        RUSLVL_variable = new Variable("Уровень владения родным языком", RUSLVL_domain, VarType.InferredRequested, "");
        LNGCNT_variable = new Variable("Кол-во изученных иностранных", LNGCNT_domain, VarType.Requested, "Кол-во иностранных языков, которыми вы владеете?");
        LNGBEG_variable = new Variable("Возраст начала изучения ин. яз.", LNGBEG_domain, VarType.Requested, "В каком возрасте вы изучали иностранный язык?");
        LNGDROP_variable = new Variable("Прерывание обучения ин. яз.", LNGDROP_domain, VarType.Requested, "Прерывали ли вы обучение иностранному языку?");
        MULTLVL_variable = new Variable("Уровень усвоения нескольких языков ", MULTLVL_domain, VarType.InferredRequested, "");
        TALKEXP_variable = new Variable("Опыт общения с носителями", TALKEXP_domain, VarType.Requested, "Имеете ли вы опыт общения с носителями языка?");
        FRNLIT_variable = new Variable("Опыт чтения иностранной литературы", FRNLIT_domain, VarType.Requested, "Приходилось ли читать литературу на ин. языке?");
        MSCUND_variable = new Variable("Уровень понимания иностранных песен", MSCUND_domain, VarType.Requested, "Можете ли вы понимать текст песен на ин. языке?");
        LNGEXP_variable = new Variable("Опыт применения ин. яз.", LNGEXP_domain, VarType.InferredRequested, "");
        FRNLLVL_variable = new Variable("Уровень владения иностранными языками", FRNLLVL_domain, VarType.InferredRequested, "");
        LLVL_variable = new Variable("Уровень языковых способностей", LLVL_domain, VarType.InferredRequested, "");
        SELFEDU_variable = new Variable("Самообучаемость", SELFEDU_domain, VarType.Requested, "Можете потратить время на самост. изучение чего-либо?");
        FRNCULT_variable = new Variable("Интерес к иностранным культурам", FRNCULT_domain, VarType.Requested, "Проявляли ли вы интерес к иностранным культурам?");
        MOTLVL_variable = new Variable("Уровень мотивации", MOTLVL_domain, VarType.InferredRequested, "");
        DLGHARD_variable = new Variable("Трудности с началом диалога", DLGHARD_domain, VarType.Requested, "Испытываете ли вы трудности с тем, чтобы начать диалог?");
        NERVOUS_variable = new Variable("Волнение при общении на ин. яз.", NERVOUS_domain, VarType.Requested, "Испытываете ли вы волнение, разговаривая на ин.языке?");
        EXPROMT_variable = new Variable("Уровень экспромта", EXPROMT_domain, VarType.Requested, "На сколько для вас сложно выступить экспромтом?");
        LNGBAR_variable = new Variable("Уровень языкового барьера", LNGBAR_domain, VarType.InferredRequested, "");
        PSYBAR_variable = new Variable("Уровень психологического барьера", PSYBAR_domain, VarType.InferredRequested, "");
        SEX_variable = new Variable("Пол", SEX_domain, VarType.Requested, "Ваш пол?");
        AGE_variable = new Variable("Возраст", AGE_domain, VarType.Requested, "Ваш возраст?");
        GENAGE_variable = new Variable("Степень гендерно-возрастного расположения к языкам", GENAGE_domain, VarType.InferredRequested, "");
        POEMLVL_variable = new Variable("Память на стихи, песни", POEMLVL_domain, VarType.Requested, "Хорошо ли вы запоминаете стихи, песни?");
        FACTLVL_variable = new Variable("Память на числа, факты", FACTLVL_domain, VarType.Requested, "Хорошо ли вы запоминаете числа, факты?");
        DIARY_variable = new Variable("Дневник напоминаний", DIARY_domain, VarType.Requested, "Ведете ли вы дневник напоминаний?");
        MEMLVL_variable = new Variable("Уровень памяти", MEMLVL_domain, VarType.InferredRequested, "");
        VOCAL_variable = new Variable("Вокал", VOCAL_domain, VarType.Requested, "Имеете ли вы вокальные способности?");
        HEARING_variable = new Variable("Музыкальный слух", HEARING_domain, VarType.Requested, "Можете ли сказать, что обладаете музыкальным слухом?");
        MSCLVL_variable = new Variable("Музыкальные способности", MSCLVL_domain, VarType.InferredRequested, "");
        QLTLVL_variable = new Variable("Уровень индивидуальных качеств", QLTLVL_domain, VarType.InferredRequested, "");
        INDLVL_variable = new Variable("Уровень индивидуальных способностей", INDLVL_domain, VarType.InferredRequested, "");
        PREDLVL_variable = new Variable("Уровень предрасположенности к изучению ин. яз.", PREDLVL_domain, VarType.Inferred, "");

        KnowledgeBase.Variables.Add(RUSBAL_variable);
        KnowledgeBase.Variables.Add(IZLOJ_variable);
        KnowledgeBase.Variables.Add(WRTLVL_variable);
        KnowledgeBase.Variables.Add(LITBAL_variable);
        KnowledgeBase.Variables.Add(READSPD_variable);
        KnowledgeBase.Variables.Add(BOOKCNT_variable);
        KnowledgeBase.Variables.Add(READLVL_variable);
        KnowledgeBase.Variables.Add(RUSLVL_variable);
        KnowledgeBase.Variables.Add(LNGCNT_variable);
        KnowledgeBase.Variables.Add(LNGBEG_variable);
        KnowledgeBase.Variables.Add(LNGDROP_variable);
        KnowledgeBase.Variables.Add(MULTLVL_variable);
        KnowledgeBase.Variables.Add(TALKEXP_variable);
        KnowledgeBase.Variables.Add(FRNLIT_variable);
        KnowledgeBase.Variables.Add(MSCUND_variable);
        KnowledgeBase.Variables.Add(LNGEXP_variable);
        KnowledgeBase.Variables.Add(FRNLLVL_variable);
        KnowledgeBase.Variables.Add(LLVL_variable);
        KnowledgeBase.Variables.Add(SELFEDU_variable);
        KnowledgeBase.Variables.Add(FRNCULT_variable);
        KnowledgeBase.Variables.Add(MOTLVL_variable);
        KnowledgeBase.Variables.Add(DLGHARD_variable);
        KnowledgeBase.Variables.Add(NERVOUS_variable);
        KnowledgeBase.Variables.Add(EXPROMT_variable);
        KnowledgeBase.Variables.Add(LNGBAR_variable);
        KnowledgeBase.Variables.Add(PSYBAR_variable);
        KnowledgeBase.Variables.Add(SEX_variable);
        KnowledgeBase.Variables.Add(AGE_variable);
        KnowledgeBase.Variables.Add(GENAGE_variable);
        KnowledgeBase.Variables.Add(POEMLVL_variable);
        KnowledgeBase.Variables.Add(FACTLVL_variable);
        KnowledgeBase.Variables.Add(DIARY_variable);
        KnowledgeBase.Variables.Add(MEMLVL_variable);
        KnowledgeBase.Variables.Add(VOCAL_variable);
        KnowledgeBase.Variables.Add(HEARING_variable);
        KnowledgeBase.Variables.Add(MSCLVL_variable);
        KnowledgeBase.Variables.Add(QLTLVL_variable);
        KnowledgeBase.Variables.Add(INDLVL_variable);
        KnowledgeBase.Variables.Add(PREDLVL_variable);

        var R1 = new Rule("R1", "");
        KnowledgeBase.Rules.Add(R1);
        R1.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[2]));
        R1.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[2]));
        R1.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[2])));
        R1.Description = string.Join(" И ", R1.Premises) + ", ТО " + string.Join(" И ", R1.Conclusions);

        var R2_1 = new Rule("R2_1", "");
        KnowledgeBase.Rules.Add(R2_1);
        R2_1.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[1]));
        R2_1.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[0]));
        R2_1.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[0])));
        R2_1.Description = string.Join(" И ", R2_1.Premises) + ", ТО " + string.Join(" И ", R2_1.Conclusions);

        var R2_2 = new Rule("R2_2", "");
        KnowledgeBase.Rules.Add(R2_2);
        R2_2.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[0]));
        R2_2.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[0]));
        R2_2.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[0])));
        R2_2.Description = string.Join(" И ", R2_2.Premises) + ", ТО " + string.Join(" И ", R2_2.Conclusions);

        var R2_3 = new Rule("R2_3", "");
        KnowledgeBase.Rules.Add(R2_3);
        R2_3.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[0]));
        R2_3.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[1]));
        R2_3.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[0])));
        R2_3.Description = string.Join(" И ", R2_3.Premises) + ", ТО " + string.Join(" И ", R2_3.Conclusions);

        var R3_1 = new Rule("R3_1", "");
        KnowledgeBase.Rules.Add(R3_1);
        R3_1.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[0]));
        R3_1.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[2]));
        R3_1.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[1])));
        R3_1.Description = string.Join(" И ", R3_1.Premises) + ", ТО " + string.Join(" И ", R3_1.Conclusions);

        var R3_2 = new Rule("R3_2", "");
        KnowledgeBase.Rules.Add(R3_2);
        R3_2.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[1]));
        R3_2.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[1]));
        R3_2.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[1])));
        R3_2.Description = string.Join(" И ", R3_2.Premises) + ", ТО " + string.Join(" И ", R3_2.Conclusions);

        var R3_3 = new Rule("R3_3", "");
        KnowledgeBase.Rules.Add(R3_3);
        R3_3.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[1]));
        R3_3.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[2]));
        R3_3.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[1])));
        R3_3.Description = string.Join(" И ", R3_3.Premises) + ", ТО " + string.Join(" И ", R3_3.Conclusions);

        var R3_4 = new Rule("R3_4", "");
        KnowledgeBase.Rules.Add(R3_4);
        R3_4.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[2]));
        R3_4.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[0]));
        R3_4.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[1])));
        R3_4.Description = string.Join(" И ", R3_4.Premises) + ", ТО " + string.Join(" И ", R3_4.Conclusions);

        var R3_5 = new Rule("R3_5", "");
        KnowledgeBase.Rules.Add(R3_5);
        R3_5.Premises.Add(new Fact(LLVL_variable, LLVL_domain.Values[2]));
        R3_5.Premises.Add(new Fact(INDLVL_variable, INDLVL_domain.Values[1]));
        R3_5.Conclusions.Add((new Fact(PREDLVL_variable, PREDLVL_domain.Values[1])));
        R3_5.Description = string.Join(" И ", R3_5.Premises) + ", ТО " + string.Join(" И ", R3_5.Conclusions);

        var R4 = new Rule("R4", "");
        KnowledgeBase.Rules.Add(R4);
        R4.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[2]));
        R4.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[3]));
        R4.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[2])));
        R4.Description = string.Join(" И ", R4.Premises) + ", ТО " + string.Join(" И ", R4.Conclusions);

        var R5_1 = new Rule("R5_1", "");
        KnowledgeBase.Rules.Add(R5_1);
        R5_1.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[0]));
        R5_1.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[0]));
        R5_1.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[0])));
        R5_1.Description = string.Join(" И ", R5_1.Premises) + ", ТО " + string.Join(" И ", R5_1.Conclusions);

        var R5_2 = new Rule("R5_2", "");
        KnowledgeBase.Rules.Add(R5_2);
        R5_2.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[0]));
        R5_2.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[1]));
        R5_2.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[0])));
        R5_2.Description = string.Join(" И ", R5_2.Premises) + ", ТО " + string.Join(" И ", R5_2.Conclusions);

        var R6_1 = new Rule("R6_1", "");
        KnowledgeBase.Rules.Add(R6_1);
        R6_1.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[0]));
        R6_1.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])); 
        R6_1.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_1.Description = string.Join(" И ", R6_1.Premises) + ", ТО " + string.Join(" И ", R6_1.Conclusions);

        var R6_2 = new Rule("R6_2", "");
        KnowledgeBase.Rules.Add(R6_2);
        R6_2.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[0]));
        R6_2.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[3])); 
        R6_2.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_2.Description = string.Join(" И ", R6_2.Premises) + ", ТО " + string.Join(" И ", R6_2.Conclusions);

        var R6_3 = new Rule("R6_3", "");
        KnowledgeBase.Rules.Add(R6_3);
        R6_3.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[1]));
        R6_3.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[0]));
        R6_3.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_3.Description = string.Join(" И ", R6_3.Premises) + ", ТО " + string.Join(" И ", R6_3.Conclusions);

        var R6_4 = new Rule("R6_4", "");
        KnowledgeBase.Rules.Add(R6_4);
        R6_4.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[1]));
        R6_4.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[1]));
        R6_4.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_4.Description = string.Join(" И ", R6_4.Premises) + ", ТО " + string.Join(" И ", R6_4.Conclusions);

        var R6_5 = new Rule("R6_5", "");
        KnowledgeBase.Rules.Add(R6_5);
        R6_5.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[1]));
        R6_5.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2]));
        R6_5.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_5.Description = string.Join(" И ", R6_5.Premises) + ", ТО " + string.Join(" И ", R6_5.Conclusions);

        var R6_6 = new Rule("R6_6", "");
        KnowledgeBase.Rules.Add(R6_6);
        R6_6.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[1]));
        R6_6.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[3]));
        R6_6.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_6.Description = string.Join(" И ", R6_6.Premises) + ", ТО " + string.Join(" И ", R6_6.Conclusions);

        var R6_7 = new Rule("R6_7", "");
        KnowledgeBase.Rules.Add(R6_7);
        R6_7.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[2]));
        R6_7.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[0])); 
        R6_7.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_7.Description = string.Join(" И ", R6_7.Premises) + ", ТО " + string.Join(" И ", R6_7.Conclusions);

        var R6_8 = new Rule("R6_8", "");
        KnowledgeBase.Rules.Add(R6_8);
        R6_8.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[2]));
        R6_8.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[1])); 
        R6_8.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_8.Description = string.Join(" И ", R6_8.Premises) + ", ТО " + string.Join(" И ", R6_8.Conclusions);

        var R6_9 = new Rule("R6_9", "");
        KnowledgeBase.Rules.Add(R6_9);
        R6_9.Premises.Add(new Fact(RUSLVL_variable, RUSLVL_domain.Values[2]));
        R6_9.Premises.Add(new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])); 
        R6_9.Conclusions.Add((new Fact(LLVL_variable, LLVL_domain.Values[1])));
        R6_9.Description = string.Join(" И ", R6_9.Premises) + ", ТО " + string.Join(" И ", R6_9.Conclusions);

        var R7_1 = new Rule("R7_1", "");
        KnowledgeBase.Rules.Add(R7_1);
        R7_1.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[2]));
        R7_1.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[2]));
        R7_1.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[2])));
        R7_1.Description = string.Join(" И ", R7_1.Premises) + ", ТО " + string.Join(" И ", R7_1.Conclusions);

        var R7_2 = new Rule("R7_2", "");
        KnowledgeBase.Rules.Add(R7_2);
        R7_2.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[2]));
        R7_2.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[1]));
        R7_2.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[2])));
        R7_2.Description = string.Join(" И ", R7_2.Premises) + ", ТО " + string.Join(" И ", R7_2.Conclusions);

        var R7_3 = new Rule("R7_3", "");
        KnowledgeBase.Rules.Add(R7_3);
        R7_3.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[1]));
        R7_3.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[2]));
        R7_3.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[2])));
        R7_3.Description = string.Join(" И ", R7_3.Premises) + ", ТО " + string.Join(" И ", R7_3.Conclusions);

        var R8 = new Rule("R8", "");
        KnowledgeBase.Rules.Add(R8);
        R8.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[0]));
        R8.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[0]));
        R8.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[0])));
        R8.Description = string.Join(" И ", R8.Premises) + ", ТО " + string.Join(" И ", R8.Conclusions);

        var R9_1 = new Rule("R9_1", "");
        KnowledgeBase.Rules.Add(R9_1);
        R9_1.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[0]));
        R9_1.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[1]));
        R9_1.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[1])));
        R9_1.Description = string.Join(" И ", R9_1.Premises) + ", ТО " + string.Join(" И ", R9_1.Conclusions);

        var R9_2 = new Rule("R9_2", "");
        KnowledgeBase.Rules.Add(R9_2);
        R9_2.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[0]));
        R9_2.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[2]));
        R9_2.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[1])));
        R9_2.Description = string.Join(" И ", R9_2.Premises) + ", ТО " + string.Join(" И ", R9_2.Conclusions);

        var R9_3 = new Rule("R9_3", "");
        KnowledgeBase.Rules.Add(R9_3);
        R9_3.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[1]));
        R9_3.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[0]));
        R9_3.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[1])));
        R9_3.Description = string.Join(" И ", R9_3.Premises) + ", ТО " + string.Join(" И ", R9_3.Conclusions);

        var R9_4 = new Rule("R9_4", "");
        KnowledgeBase.Rules.Add(R9_4);
        R9_4.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[1]));
        R9_4.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[1]));
        R9_4.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[1])));
        R9_4.Description = string.Join(" И ", R9_4.Premises) + ", ТО " + string.Join(" И ", R9_4.Conclusions);

        var R9_5 = new Rule("R9_5", "");
        KnowledgeBase.Rules.Add(R9_5);
        R9_5.Premises.Add(new Fact(WRTLVL_variable, WRTLVL_domain.Values[2]));
        R9_5.Premises.Add(new Fact(READLVL_variable, READLVL_domain.Values[0]));
        R9_5.Conclusions.Add((new Fact(RUSLVL_variable, RUSLVL_domain.Values[1])));
        R9_5.Description = string.Join(" И ", R9_5.Premises) + ", ТО " + string.Join(" И ", R9_5.Conclusions);

        var R10 = new Rule("R10", "");
        KnowledgeBase.Rules.Add(R10);
        R10.Premises.Add(new Fact(RUSBAL_variable, RUSBAL_domain.Values[2]));
        R10.Premises.Add(new Fact(IZLOJ_variable, IZLOJ_domain.Values[0]));
        R10.Conclusions.Add((new Fact(WRTLVL_variable, WRTLVL_domain.Values[2])));
        R10.Description = string.Join(" И ", R10.Premises) + ", ТО " + string.Join(" И ", R10.Conclusions);

        var R11 = new Rule("R11", "");
        KnowledgeBase.Rules.Add(R11);
        R11.Premises.Add(new Fact(RUSBAL_variable, RUSBAL_domain.Values[0]));
        R11.Premises.Add(new Fact(IZLOJ_variable, IZLOJ_domain.Values[1]));
        R11.Conclusions.Add((new Fact(WRTLVL_variable, WRTLVL_domain.Values[0])));
        R11.Description = string.Join(" И ", R11.Premises) + ", ТО " + string.Join(" И ", R11.Conclusions);

        var R12_1 = new Rule("R12_1", "");
        KnowledgeBase.Rules.Add(R12_1);
        R12_1.Premises.Add(new Fact(RUSBAL_variable, RUSBAL_domain.Values[0]));
        R12_1.Premises.Add(new Fact(IZLOJ_variable, IZLOJ_domain.Values[0]));
        R12_1.Conclusions.Add((new Fact(WRTLVL_variable, WRTLVL_domain.Values[1])));
        R12_1.Description = string.Join(" И ", R12_1.Premises) + ", ТО " + string.Join(" И ", R12_1.Conclusions);

        var R12_2 = new Rule("R12_2", "");
        KnowledgeBase.Rules.Add(R12_2);
        R12_2.Premises.Add(new Fact(RUSBAL_variable, RUSBAL_domain.Values[1]));
        R12_2.Premises.Add(new Fact(IZLOJ_variable, IZLOJ_domain.Values[0]));
        R12_2.Conclusions.Add((new Fact(WRTLVL_variable, WRTLVL_domain.Values[1])));
        R12_2.Description = string.Join(" И ", R12_2.Premises) + ", ТО " + string.Join(" И ", R12_2.Conclusions);

        var R12_3 = new Rule("R12_3", "");
        KnowledgeBase.Rules.Add(R12_3);
        R12_3.Premises.Add(new Fact(RUSBAL_variable, RUSBAL_domain.Values[1]));
        R12_3.Premises.Add(new Fact(IZLOJ_variable, IZLOJ_domain.Values[1]));
        R12_3.Conclusions.Add((new Fact(WRTLVL_variable, WRTLVL_domain.Values[1])));
        R12_3.Description = string.Join(" И ", R12_3.Premises) + ", ТО " + string.Join(" И ", R12_3.Conclusions);

        var R12_4 = new Rule("R12_4", "");
        KnowledgeBase.Rules.Add(R12_4);
        R12_4.Premises.Add(new Fact(RUSBAL_variable, RUSBAL_domain.Values[2]));
        R12_4.Premises.Add(new Fact(IZLOJ_variable, IZLOJ_domain.Values[1]));
        R12_4.Conclusions.Add((new Fact(WRTLVL_variable, WRTLVL_domain.Values[1])));
        R12_4.Description = string.Join(" И ", R12_4.Premises) + ", ТО " + string.Join(" И ", R12_4.Conclusions);

        var R13_1 = new Rule("R13_1", "");
        KnowledgeBase.Rules.Add(R13_1);
        R13_1.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[1]));
        R13_1.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[1]));
        R13_1.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[2]));
        R13_1.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[2])));
        R13_1.Description = string.Join(" И ", R13_1.Premises) + ", ТО " + string.Join(" И ", R13_1.Conclusions);

        var R13_2 = new Rule("R13_2", "");
        KnowledgeBase.Rules.Add(R13_2);
        R13_2.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[1]));
        R13_2.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[1]));
        R13_2.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[3]));
        R13_2.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[2])));
        R13_2.Description = string.Join(" И ", R13_2.Premises) + ", ТО " + string.Join(" И ", R13_2.Conclusions);

        var R14 = new Rule("R14", "");
        KnowledgeBase.Rules.Add(R14);
        R14.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[0]));
        R14.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[0]));
        R14.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[0]));
        R14.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[0])));
        R14.Description = string.Join(" И ", R14.Premises) + ", ТО " + string.Join(" И ", R14.Conclusions);

        var R15_1 = new Rule("R15_1", "");
        KnowledgeBase.Rules.Add(R15_1);
        R15_1.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[0]));
        R15_1.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[0]));
        R15_1.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[1])); 
        R15_1.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[1])));
        R15_1.Description = string.Join(" И ", R15_1.Premises) + ", ТО " + string.Join(" И ", R15_1.Conclusions);

        var R15_2 = new Rule("R15_2", "");
        KnowledgeBase.Rules.Add(R15_2);
        R15_2.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[0]));
        R15_2.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[0]));
        R15_2.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[2])); 
        R15_2.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[1])));
        R15_2.Description = string.Join(" И ", R15_2.Premises) + ", ТО " + string.Join(" И ", R15_2.Conclusions);

        var R15_3 = new Rule("R15_3", "");
        KnowledgeBase.Rules.Add(R15_3);
        R15_3.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[0]));
        R15_3.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[0]));
        R15_3.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[3])); 
        R15_3.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[1])));
        R15_3.Description = string.Join(" И ", R15_3.Premises) + ", ТО " + string.Join(" И ", R15_3.Conclusions);

        var R15_4 = new Rule("R15_4", "");
        KnowledgeBase.Rules.Add(R15_4);
        R15_4.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[0]));
        R15_4.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[1]));
        R15_4.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[1])));
        R15_4.Description = string.Join(" И ", R15_4.Premises) + ", ТО " + string.Join(" И ", R15_4.Conclusions);

        var R15_5 = new Rule("R15_5", "");
        KnowledgeBase.Rules.Add(R15_5);
        R15_5.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[1]));
        R15_5.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[0])); 
        R15_5.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[1])));
        R15_5.Description = string.Join(" И ", R15_5.Premises) + ", ТО " + string.Join(" И ", R15_5.Conclusions);

        var R15_6 = new Rule("R15_6", "");
        KnowledgeBase.Rules.Add(R15_6);
        R15_6.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[1]));
        R15_6.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[1]));
        R15_6.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[0])); 
        R15_6.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[1])));
        R15_6.Description = string.Join(" И ", R15_6.Premises) + ", ТО " + string.Join(" И ", R15_6.Conclusions);

        var R15_7 = new Rule("R15_7", "");
        KnowledgeBase.Rules.Add(R15_7);
        R15_7.Premises.Add(new Fact(LITBAL_variable, LITBAL_domain.Values[1]));
        R15_7.Premises.Add(new Fact(READSPD_variable, READSPD_domain.Values[1]));
        R15_7.Premises.Add(new Fact(BOOKCNT_variable, BOOKCNT_domain.Values[1])); 
        R15_7.Conclusions.Add((new Fact(READLVL_variable, READLVL_domain.Values[1])));
        R15_7.Description = string.Join(" И ", R15_7.Premises) + ", ТО " + string.Join(" И ", R15_7.Conclusions);

        var R16 = new Rule("R16", "");
        KnowledgeBase.Rules.Add(R16);
        R16.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[0]));
        R16.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[0])));
        R16.Description = string.Join(" И ", R16.Premises) + ", ТО " + string.Join(" И ", R16.Conclusions);

        var R17_1 = new Rule("R17_1", "");
        KnowledgeBase.Rules.Add(R17_1);
        R17_1.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R17_1.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[2]));
        R17_1.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[2]));
        R17_1.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[3])));
        R17_1.Description = string.Join(" И ", R17_1.Premises) + ", ТО " + string.Join(" И ", R17_1.Conclusions);

        var R17_2 = new Rule("R17_2", "");
        KnowledgeBase.Rules.Add(R17_2);
        R17_2.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R17_2.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[2]));
        R17_2.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[2]));
        R17_2.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[3])));
        R17_2.Description = string.Join(" И ", R17_2.Premises) + ", ТО " + string.Join(" И ", R17_2.Conclusions);

        var R17_3 = new Rule("R17_3", "");
        KnowledgeBase.Rules.Add(R17_3);
        R17_3.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R17_3.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[2]));
        R17_3.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[1]));
        R17_3.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[3])));
        R17_3.Description = string.Join(" И ", R17_3.Premises) + ", ТО " + string.Join(" И ", R17_3.Conclusions);

        var R17_4 = new Rule("R17_4", "");
        KnowledgeBase.Rules.Add(R17_4);
        R17_4.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R17_4.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[1]));
        R17_4.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[2]));
        R17_4.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[3])));
        R17_4.Description = string.Join(" И ", R17_4.Premises) + ", ТО " + string.Join(" И ", R17_4.Conclusions);

        var R18_1 = new Rule("R18_1", "");
        KnowledgeBase.Rules.Add(R18_1);
        R18_1.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R18_1.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[0]));
        R18_1.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[0]));
        R18_1.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[1])));
        R18_1.Description = string.Join(" И ", R18_1.Premises) + ", ТО " + string.Join(" И ", R18_1.Conclusions);

        var R18_2 = new Rule("R18_2", "");
        KnowledgeBase.Rules.Add(R18_2);
        R18_2.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R18_2.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[0]));
        R18_2.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[0]));
        R18_2.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[1])));
        R18_2.Description = string.Join(" И ", R18_2.Premises) + ", ТО " + string.Join(" И ", R18_2.Conclusions);

        var R19_1 = new Rule("R19_1", "");
        KnowledgeBase.Rules.Add(R19_1);
        R19_1.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R19_1.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[0]));
        R19_1.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])); 
        R19_1.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_1.Description = string.Join(" И ", R19_1.Premises) + ", ТО " + string.Join(" И ", R19_1.Conclusions);

        var R19_2 = new Rule("R19_2", "");
        KnowledgeBase.Rules.Add(R19_2);
        R19_2.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R19_2.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[0]));
        R19_2.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[2])); 
        R19_2.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_2.Description = string.Join(" И ", R19_2.Premises) + ", ТО " + string.Join(" И ", R19_2.Conclusions);

        var R19_3 = new Rule("R19_3", "");
        KnowledgeBase.Rules.Add(R19_3);
        R19_3.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R19_3.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[1]));
        R19_3.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[0]));
        R19_3.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_3.Description = string.Join(" И ", R19_3.Premises) + ", ТО " + string.Join(" И ", R19_3.Conclusions);

        var R19_4 = new Rule("R19_4", "");
        KnowledgeBase.Rules.Add(R19_4);
        R19_4.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R19_4.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[1]));
        R19_4.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[1]));
        R19_4.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_4.Description = string.Join(" И ", R19_4.Premises) + ", ТО " + string.Join(" И ", R19_4.Conclusions);

        var R19_5 = new Rule("R19_5", "");
        KnowledgeBase.Rules.Add(R19_5);
        R19_5.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R19_5.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[1]));
        R19_5.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[2]));
        R19_5.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_5.Description = string.Join(" И ", R19_5.Premises) + ", ТО " + string.Join(" И ", R19_5.Conclusions);

        var R19_6 = new Rule("R19_6", "");
        KnowledgeBase.Rules.Add(R19_6);
        R19_6.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R19_6.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[2]));
        R19_6.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[0])); 
        R19_6.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_6.Description = string.Join(" И ", R19_6.Premises) + ", ТО " + string.Join(" И ", R19_6.Conclusions);

        var R19_7 = new Rule("R19_7", "");
        KnowledgeBase.Rules.Add(R19_7);
        R19_7.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[1]));
        R19_7.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[2]));
        R19_7.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])); 
        R19_7.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_7.Description = string.Join(" И ", R19_7.Premises) + ", ТО " + string.Join(" И ", R19_7.Conclusions);

        var R19_8 = new Rule("R19_8", "");
        KnowledgeBase.Rules.Add(R19_8);
        R19_8.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R19_8.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[0]));
        R19_8.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[1]));
        R19_8.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_8.Description = string.Join(" И ", R19_8.Premises) + ", ТО " + string.Join(" И ", R19_8.Conclusions);

        var R19_9 = new Rule("R19_9", "");
        KnowledgeBase.Rules.Add(R19_9);
        R19_9.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R19_9.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[0]));
        R19_9.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[2]));
        R19_9.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_9.Description = string.Join(" И ", R19_9.Premises) + ", ТО " + string.Join(" И ", R19_9.Conclusions);

        var R19_10 = new Rule("R19_10", "");
        KnowledgeBase.Rules.Add(R19_10);
        R19_10.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R19_10.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[1]));
        R19_10.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[0]));
        R19_10.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_10.Description = string.Join(" И ", R19_10.Premises) + ", ТО " + string.Join(" И ", R19_10.Conclusions);

        var R19_11 = new Rule("R19_11", "");
        KnowledgeBase.Rules.Add(R19_11);
        R19_11.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R19_11.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[1]));
        R19_11.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[1]));
        R19_11.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_11.Description = string.Join(" И ", R19_11.Premises) + ", ТО " + string.Join(" И ", R19_11.Conclusions);

        var R19_12 = new Rule("R19_12", "");
        KnowledgeBase.Rules.Add(R19_12);
        R19_12.Premises.Add(new Fact(LNGCNT_variable, LNGCNT_domain.Values[2]));
        R19_12.Premises.Add(new Fact(MULTLVL_variable, MULTLVL_domain.Values[2]));
        R19_12.Premises.Add(new Fact(LNGEXP_variable, LNGEXP_domain.Values[0]));
        R19_12.Conclusions.Add((new Fact(FRNLLVL_variable, FRNLLVL_domain.Values[2])));
        R19_12.Description = string.Join(" И ", R19_12.Premises) + ", ТО " + string.Join(" И ", R19_12.Conclusions);

        var R20 = new Rule("R20", "");
        KnowledgeBase.Rules.Add(R20);
        R20.Premises.Add(new Fact(LNGBEG_variable, LNGBEG_domain.Values[1]));
        R20.Premises.Add(new Fact(LNGDROP_variable, LNGDROP_domain.Values[0]));
        R20.Conclusions.Add((new Fact(MULTLVL_variable, MULTLVL_domain.Values[2])));
        R20.Description = string.Join(" И ", R20.Premises) + ", ТО " + string.Join(" И ", R20.Conclusions);

        var R21 = new Rule("R21", "");
        KnowledgeBase.Rules.Add(R21);
        R21.Premises.Add(new Fact(LNGBEG_variable, LNGBEG_domain.Values[0]));
        R21.Premises.Add(new Fact(LNGDROP_variable, LNGDROP_domain.Values[1]));
        R21.Conclusions.Add((new Fact(MULTLVL_variable, MULTLVL_domain.Values[0])));
        R21.Description = string.Join(" И ", R21.Premises) + ", ТО " + string.Join(" И ", R21.Conclusions);

        var R22_1 = new Rule("R22_1", "");
        KnowledgeBase.Rules.Add(R22_1);
        R22_1.Premises.Add(new Fact(LNGBEG_variable, LNGBEG_domain.Values[1]));
        R22_1.Premises.Add(new Fact(LNGDROP_variable, LNGDROP_domain.Values[1]));
        R22_1.Conclusions.Add((new Fact(MULTLVL_variable, MULTLVL_domain.Values[1])));
        R22_1.Description = string.Join(" И ", R22_1.Premises) + ", ТО " + string.Join(" И ", R22_1.Conclusions);

        var R22_2 = new Rule("R22_2", "");
        KnowledgeBase.Rules.Add(R22_2);
        R22_2.Premises.Add(new Fact(LNGBEG_variable, LNGBEG_domain.Values[0]));
        R22_2.Premises.Add(new Fact(LNGDROP_variable, LNGDROP_domain.Values[0]));
        R22_2.Conclusions.Add((new Fact(MULTLVL_variable, MULTLVL_domain.Values[1])));
        R22_2.Description = string.Join(" И ", R22_2.Premises) + ", ТО " + string.Join(" И ", R22_2.Conclusions);

        var R23 = new Rule("R23", "");
        KnowledgeBase.Rules.Add(R23);
        R23.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[2]));
        R23.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[1]));
        R23.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[2]));
        R23.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[2])));
        R23.Description = string.Join(" И ", R23.Premises) + ", ТО " + string.Join(" И ", R23.Conclusions);

        var R24 = new Rule("R24", "");
        KnowledgeBase.Rules.Add(R24);
        R24.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[0]));
        R24.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[0]));
        R24.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[0]));
        R24.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[0])));
        R24.Description = string.Join(" И ", R24.Premises) + ", ТО " + string.Join(" И ", R24.Conclusions);

        var R25_1 = new Rule("R25_1", "");
        KnowledgeBase.Rules.Add(R25_1);
        R25_1.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[0]));
        R25_1.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[0]));
        R25_1.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[1]));
        R25_1.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_1.Description = string.Join(" И ", R25_1.Premises) + ", ТО " + string.Join(" И ", R25_1.Conclusions);

        var R25_2 = new Rule("R25_2", "");
        KnowledgeBase.Rules.Add(R25_2);
        R25_2.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[0]));
        R25_2.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[0]));
        R25_2.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[2]));
        R25_2.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_2.Description = string.Join(" И ", R25_2.Premises) + ", ТО " + string.Join(" И ", R25_2.Conclusions);

        var R25_3 = new Rule("R25_3", "");
        KnowledgeBase.Rules.Add(R25_3);
        R25_3.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[0]));
        R25_3.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[1]));
        R25_3.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[0]));
        R25_3.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_3.Description = string.Join(" И ", R25_3.Premises) + ", ТО " + string.Join(" И ", R25_3.Conclusions);

        var R25_4 = new Rule("R25_4", "");
        KnowledgeBase.Rules.Add(R25_4);
        R25_4.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[0]));
        R25_4.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[1]));
        R25_4.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[1]));
        R25_4.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_4.Description = string.Join(" И ", R25_4.Premises) + ", ТО " + string.Join(" И ", R25_4.Conclusions);

        var R25_5 = new Rule("R25_5", "");
        KnowledgeBase.Rules.Add(R25_5);
        R25_5.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[0]));
        R25_5.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[1]));
        R25_5.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[2]));
        R25_5.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_5.Description = string.Join(" И ", R25_5.Premises) + ", ТО " + string.Join(" И ", R25_5.Conclusions);

        var R25_6 = new Rule("R25_6", "");
        KnowledgeBase.Rules.Add(R25_6);
        R25_6.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[1])); 
        R25_6.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_6.Description = string.Join(" И ", R25_6.Premises) + ", ТО " + string.Join(" И ", R25_6.Conclusions);

        var R25_7 = new Rule("R25_7", "");
        KnowledgeBase.Rules.Add(R25_7);
        R25_7.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[2]));
        R25_7.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[0]));
        R25_7.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[1]));
        R25_7.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_7.Description = string.Join(" И ", R25_7.Premises) + ", ТО " + string.Join(" И ", R25_7.Conclusions);

        var R25_8 = new Rule("R25_8", "");
        KnowledgeBase.Rules.Add(R25_8);
        R25_8.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[2]));
        R25_8.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[0]));
        R25_8.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[2]));
        R25_8.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_8.Description = string.Join(" И ", R25_8.Premises) + ", ТО " + string.Join(" И ", R25_8.Conclusions);

        var R25_9 = new Rule("R25_9", "");
        KnowledgeBase.Rules.Add(R25_9);
        R25_9.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[2]));
        R25_9.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[1]));
        R25_9.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[0]));
        R25_9.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_9.Description = string.Join(" И ", R25_9.Premises) + ", ТО " + string.Join(" И ", R25_9.Conclusions);

        var R25_10 = new Rule("R25_10", "");
        KnowledgeBase.Rules.Add(R25_10);
        R25_10.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[2]));
        R25_10.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[1]));
        R25_10.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[1]));
        R25_10.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_10.Description = string.Join(" И ", R25_10.Premises) + ", ТО " + string.Join(" И ", R25_10.Conclusions);

        var R25_11 = new Rule("R25_11", "");
        KnowledgeBase.Rules.Add(R25_11);
        R25_11.Premises.Add(new Fact(TALKEXP_variable, TALKEXP_domain.Values[2]));
        R25_11.Premises.Add(new Fact(FRNLIT_variable, FRNLIT_domain.Values[1]));
        R25_11.Premises.Add(new Fact(MSCUND_variable, MSCUND_domain.Values[2]));
        R25_11.Conclusions.Add((new Fact(LNGEXP_variable, LNGEXP_domain.Values[1])));
        R25_11.Description = string.Join(" И ", R25_11.Premises) + ", ТО " + string.Join(" И ", R25_11.Conclusions);

        var R26_1 = new Rule("R26_1", "");
        KnowledgeBase.Rules.Add(R26_1);
        R26_1.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[0]));
        R26_1.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[1]));
        R26_1.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[2])));
        R26_1.Description = string.Join(" И ", R26_1.Premises) + ", ТО " + string.Join(" И ", R26_1.Conclusions);

        var R26_2 = new Rule("R26_2", "");
        KnowledgeBase.Rules.Add(R26_2);
        R26_2.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[0]));
        R26_2.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[2]));
        R26_2.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[2])));
        R26_2.Description = string.Join(" И ", R26_2.Premises) + ", ТО " + string.Join(" И ", R26_2.Conclusions);

        var R26_3 = new Rule("R26_3", "");
        KnowledgeBase.Rules.Add(R26_3);
        R26_3.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[1]));
        R26_3.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[2]));
        R26_3.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[2])));
        R26_3.Description = string.Join(" И ", R26_3.Premises) + ", ТО " + string.Join(" И ", R26_3.Conclusions);

        var R27_1 = new Rule("R27_1", "");
        KnowledgeBase.Rules.Add(R27_1);
        R27_1.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[2]));
        R27_1.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[0]));
        R27_1.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[0])));
        R27_1.Description = string.Join(" И ", R27_1.Premises) + ", ТО " + string.Join(" И ", R27_1.Conclusions);

        var R27_2 = new Rule("R27_2", "");
        KnowledgeBase.Rules.Add(R27_2);
        R27_2.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[2]));
        R27_2.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[1]));
        R27_2.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[0])));
        R27_2.Description = string.Join(" И ", R27_2.Premises) + ", ТО " + string.Join(" И ", R27_2.Conclusions);

        var R28_1 = new Rule("R28_1", "");
        KnowledgeBase.Rules.Add(R28_1);
        R28_1.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[0]));
        R28_1.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[0]));
        R28_1.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[1])));
        R28_1.Description = string.Join(" И ", R28_1.Premises) + ", ТО " + string.Join(" И ", R28_1.Conclusions);

        var R28_2 = new Rule("R28_2", "");
        KnowledgeBase.Rules.Add(R28_2);
        R28_2.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[1]));
        R28_2.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[0]));
        R28_2.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[1])));
        R28_2.Description = string.Join(" И ", R28_2.Premises) + ", ТО " + string.Join(" И ", R28_2.Conclusions);

        var R28_3 = new Rule("R28_3", "");
        KnowledgeBase.Rules.Add(R28_3);
        R28_3.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[1]));
        R28_3.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[1]));
        R28_3.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[1])));
        R28_3.Description = string.Join(" И ", R28_3.Premises) + ", ТО " + string.Join(" И ", R28_3.Conclusions);

        var R28_4 = new Rule("R28_4", "");
        KnowledgeBase.Rules.Add(R28_4);
        R28_4.Premises.Add(new Fact(PSYBAR_variable, PSYBAR_domain.Values[2]));
        R28_4.Premises.Add(new Fact(QLTLVL_variable, QLTLVL_domain.Values[2]));
        R28_4.Conclusions.Add((new Fact(INDLVL_variable, INDLVL_domain.Values[1])));
        R28_4.Description = string.Join(" И ", R28_4.Premises) + ", ТО " + string.Join(" И ", R28_4.Conclusions);

        var R29 = new Rule("R29", "");
        KnowledgeBase.Rules.Add(R29);
        R29.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[2]));
        R29.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[0]));
        R29.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[0])));
        R29.Description = string.Join(" И ", R29.Premises) + ", ТО " + string.Join(" И ", R29.Conclusions);

        var R30_1 = new Rule("R30_1", "");
        KnowledgeBase.Rules.Add(R30_1);
        R30_1.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[0]));
        R30_1.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[0]));
        R30_1.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[2])));
        R30_1.Description = string.Join(" И ", R30_1.Premises) + ", ТО " + string.Join(" И ", R30_1.Conclusions);

        var R30_2 = new Rule("R30_2", "");
        KnowledgeBase.Rules.Add(R30_2);
        R30_2.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[0]));
        R30_2.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[1]));
        R30_2.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[2])));
        R30_2.Description = string.Join(" И ", R30_2.Premises) + ", ТО " + string.Join(" И ", R30_2.Conclusions);

        var R31_1 = new Rule("R31_1", "");
        KnowledgeBase.Rules.Add(R31_1);
        R31_1.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[0]));
        R31_1.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[2]));
        R31_1.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[1])));
        R31_1.Description = string.Join(" И ", R31_1.Premises) + ", ТО " + string.Join(" И ", R31_1.Conclusions);

        var R31_2 = new Rule("R31_2", "");
        KnowledgeBase.Rules.Add(R31_2);
        R31_2.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[1]));
        R31_2.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[0]));
        R31_2.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[1])));
        R31_2.Description = string.Join(" И ", R31_2.Premises) + ", ТО " + string.Join(" И ", R31_2.Conclusions);

        var R31_3 = new Rule("R31_3", "");
        KnowledgeBase.Rules.Add(R31_3);
        R31_3.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[1]));
        R31_3.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[1]));
        R31_3.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[1])));
        R31_3.Description = string.Join(" И ", R31_3.Premises) + ", ТО " + string.Join(" И ", R31_3.Conclusions);

        var R31_4 = new Rule("R31_4", "");
        KnowledgeBase.Rules.Add(R31_4);
        R31_4.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[1]));
        R31_4.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[2]));
        R31_4.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[1])));
        R31_4.Description = string.Join(" И ", R31_4.Premises) + ", ТО " + string.Join(" И ", R31_4.Conclusions);

        var R31_5 = new Rule("R31_5", "");
        KnowledgeBase.Rules.Add(R31_5);
        R31_5.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[2]));
        R31_5.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[1]));
        R31_5.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[1])));
        R31_5.Description = string.Join(" И ", R31_5.Premises) + ", ТО " + string.Join(" И ", R31_5.Conclusions);

        var R31_6 = new Rule("R31_6", "");
        KnowledgeBase.Rules.Add(R31_6);
        R31_6.Premises.Add(new Fact(MOTLVL_variable, MOTLVL_domain.Values[2]));
        R31_6.Premises.Add(new Fact(LNGBAR_variable, LNGBAR_domain.Values[2]));
        R31_6.Conclusions.Add((new Fact(PSYBAR_variable, PSYBAR_domain.Values[1])));
        R31_6.Description = string.Join(" И ", R31_6.Premises) + ", ТО " + string.Join(" И ", R31_6.Conclusions);

        var R32 = new Rule("R32", "");
        KnowledgeBase.Rules.Add(R32);
        R32.Premises.Add(new Fact(SELFEDU_variable, SELFEDU_domain.Values[1]));
        R32.Premises.Add(new Fact(FRNCULT_variable, FRNCULT_domain.Values[1]));
        R32.Conclusions.Add((new Fact(MOTLVL_variable, MOTLVL_domain.Values[2])));
        R32.Description = string.Join(" И ", R32.Premises) + ", ТО " + string.Join(" И ", R32.Conclusions);

        var R33_1 = new Rule("R33_1", "");
        KnowledgeBase.Rules.Add(R33_1);
        R33_1.Premises.Add(new Fact(SELFEDU_variable, SELFEDU_domain.Values[0]));
        R33_1.Premises.Add(new Fact(FRNCULT_variable, FRNCULT_domain.Values[0]));
        R33_1.Conclusions.Add((new Fact(MOTLVL_variable, MOTLVL_domain.Values[0])));
        R33_1.Description = string.Join(" И ", R33_1.Premises) + ", ТО " + string.Join(" И ", R33_1.Conclusions);

        var R33_2 = new Rule("R33_2", "");
        KnowledgeBase.Rules.Add(R33_2);
        R33_2.Premises.Add(new Fact(SELFEDU_variable, SELFEDU_domain.Values[0]));
        R33_2.Premises.Add(new Fact(FRNCULT_variable, FRNCULT_domain.Values[1]));
        R33_2.Conclusions.Add((new Fact(MOTLVL_variable, MOTLVL_domain.Values[0])));
        R33_2.Description = string.Join(" И ", R33_2.Premises) + ", ТО " + string.Join(" И ", R33_2.Conclusions);

        var R34 = new Rule("R34", "");
        KnowledgeBase.Rules.Add(R34);
        R34.Premises.Add(new Fact(SELFEDU_variable, SELFEDU_domain.Values[1]));
        R34.Premises.Add(new Fact(FRNCULT_variable, FRNCULT_domain.Values[0]));
        R34.Conclusions.Add((new Fact(MOTLVL_variable, MOTLVL_domain.Values[1])));
        R34.Description = string.Join(" И ", R34.Premises) + ", ТО " + string.Join(" И ", R34.Conclusions);

        var R35 = new Rule("R35", "");
        KnowledgeBase.Rules.Add(R35);
        R35.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[0]));
        R35.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[0]));
        R35.Premises.Add(new Fact(EXPROMT_variable, EXPROMT_domain.Values[2]));
        R35.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[0])));
        R35.Description = string.Join(" И ", R35.Premises) + ", ТО " + string.Join(" И ", R35.Conclusions);

        var R36 = new Rule("R36", "");
        KnowledgeBase.Rules.Add(R36);
        R36.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[1]));
        R36.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[1]));
        R36.Premises.Add(new Fact(EXPROMT_variable, EXPROMT_domain.Values[0]));
        R36.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[2])));
        R36.Description = string.Join(" И ", R36.Premises) + ", ТО " + string.Join(" И ", R36.Conclusions);

        var R37_1 = new Rule("R37_1", "");
        KnowledgeBase.Rules.Add(R37_1);
        R37_1.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[0]));
        R37_1.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[0]));
        R37_1.Premises.Add(new Fact(EXPROMT_variable, EXPROMT_domain.Values[0]));
        R37_1.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[1])));
        R37_1.Description = string.Join(" И ", R37_1.Premises) + ", ТО " + string.Join(" И ", R37_1.Conclusions);

        var R37_2 = new Rule("R37_2", "");
        KnowledgeBase.Rules.Add(R37_2);
        R37_2.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[0]));
        R37_2.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[0]));
        R37_2.Premises.Add(new Fact(EXPROMT_variable, EXPROMT_domain.Values[1]));
        R37_2.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[1])));
        R37_2.Description = string.Join(" И ", R37_2.Premises) + ", ТО " + string.Join(" И ", R37_2.Conclusions);

        var R37_3 = new Rule("R37_3", "");
        KnowledgeBase.Rules.Add(R37_3);
        R37_3.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[0]));
        R37_3.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[1]));
        R37_3.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[1])));
        R37_3.Description = string.Join(" И ", R37_3.Premises) + ", ТО " + string.Join(" И ", R37_3.Conclusions);

        var R37_4 = new Rule("R37_4", "");
        KnowledgeBase.Rules.Add(R37_4);
        R37_4.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[1]));
        R37_4.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[0]));
        R37_4.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[1])));
        R37_4.Description = string.Join(" И ", R37_4.Premises) + ", ТО " + string.Join(" И ", R37_4.Conclusions);

        var R37_5 = new Rule("R37_5", "");
        KnowledgeBase.Rules.Add(R37_5);
        R37_5.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[1]));
        R37_5.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[1]));
        R37_5.Premises.Add(new Fact(EXPROMT_variable, EXPROMT_domain.Values[1]));
        R37_5.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[1])));
        R37_5.Description = string.Join(" И ", R37_5.Premises) + ", ТО " + string.Join(" И ", R37_5.Conclusions);

        var R37_6 = new Rule("R37_6", "");
        KnowledgeBase.Rules.Add(R37_6);
        R37_6.Premises.Add(new Fact(DLGHARD_variable, DLGHARD_domain.Values[1]));
        R37_6.Premises.Add(new Fact(NERVOUS_variable, NERVOUS_domain.Values[1]));
        R37_6.Premises.Add(new Fact(EXPROMT_variable, EXPROMT_domain.Values[2]));
        R37_6.Conclusions.Add((new Fact(LNGBAR_variable, LNGBAR_domain.Values[1])));
        R37_6.Description = string.Join(" И ", R37_6.Premises) + ", ТО " + string.Join(" И ", R37_6.Conclusions);

        var R38_1 = new Rule("R38_1", "");
        KnowledgeBase.Rules.Add(R38_1);
        R38_1.Premises.Add(new Fact(GENAGE_variable, GENAGE_domain.Values[1]));
        R38_1.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[2])));
        R38_1.Description = string.Join(" И ", R38_1.Premises) + ", ТО " + string.Join(" И ", R38_1.Conclusions);

        var R38_2 = new Rule("R38_2", "");
        KnowledgeBase.Rules.Add(R38_2);
        R38_2.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[1]));
        R38_2.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[1]));
        R38_2.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[2])));
        R38_2.Description = string.Join(" И ", R38_2.Premises) + ", ТО " + string.Join(" И ", R38_2.Conclusions);

        var R38_3 = new Rule("R38_3", "");
        KnowledgeBase.Rules.Add(R38_3);
        R38_3.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[2]));
        R38_3.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[1]));
        R38_3.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[2])));
        R38_3.Description = string.Join(" И ", R38_3.Premises) + ", ТО " + string.Join(" И ", R38_3.Conclusions);

        var R39 = new Rule("R39", "");
        KnowledgeBase.Rules.Add(R39);
        R39.Premises.Add(new Fact(GENAGE_variable, GENAGE_domain.Values[0]));
        R39.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[0]));
        R39.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[0]));
        R39.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[0])));
        R39.Description = string.Join(" И ", R39.Premises) + ", ТО " + string.Join(" И ", R39.Conclusions);

        var R40_1 = new Rule("R40_1", "");
        KnowledgeBase.Rules.Add(R40_1);
        R40_1.Premises.Add(new Fact(GENAGE_variable, GENAGE_domain.Values[0]));
        R40_1.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_1.Description = string.Join(" И ", R40_1.Premises) + ", ТО " + string.Join(" И ", R40_1.Conclusions);

        var R40_2 = new Rule("R40_2", "");
        KnowledgeBase.Rules.Add(R40_2);
        R40_2.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[0]));
        R40_2.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[1]));
        R40_2.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_2.Description = string.Join(" И ", R40_2.Premises) + ", ТО " + string.Join(" И ", R40_2.Conclusions);

        var R40_3 = new Rule("R40_3", "");
        KnowledgeBase.Rules.Add(R40_3);
        R40_3.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[1]));
        R40_3.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[0]));
        R40_3.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_3.Description = string.Join(" И ", R40_3.Premises) + ", ТО " + string.Join(" И ", R40_3.Conclusions);

        var R40_4 = new Rule("R40_4", "");
        KnowledgeBase.Rules.Add(R40_4);
        R40_4.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[1]));
        R40_4.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[1]));
        R40_4.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_4.Description = string.Join(" И ", R40_4.Premises) + ", ТО " + string.Join(" И ", R40_4.Conclusions);

        var R40_5 = new Rule("R40_5", "");
        KnowledgeBase.Rules.Add(R40_5);
        R40_5.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[2]));
        R40_5.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[0]));
        R40_5.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_5.Description = string.Join(" И ", R40_5.Premises) + ", ТО " + string.Join(" И ", R40_5.Conclusions);

        var R40_6 = new Rule("R40_6", "");
        KnowledgeBase.Rules.Add(R40_6);
        R40_6.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[2]));
        R40_6.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[1]));
        R40_6.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_6.Description = string.Join(" И ", R40_6.Premises) + ", ТО " + string.Join(" И ", R40_6.Conclusions);

        var R40_7 = new Rule("R40_7", "");
        KnowledgeBase.Rules.Add(R40_7);
        R40_7.Premises.Add(new Fact(GENAGE_variable, GENAGE_domain.Values[1]));
        R40_7.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[0]));
        R40_7.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_7.Description = string.Join(" И ", R40_7.Premises) + ", ТО " + string.Join(" И ", R40_7.Conclusions);

        var R40_8 = new Rule("R40_8", "");
        KnowledgeBase.Rules.Add(R40_8);
        R40_8.Premises.Add(new Fact(GENAGE_variable, GENAGE_domain.Values[1]));
        R40_8.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[1]));
        R40_8.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[0]));
        R40_8.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_8.Description = string.Join(" И ", R40_8.Premises) + ", ТО " + string.Join(" И ", R40_8.Conclusions);

        var R40_9 = new Rule("R40_9", "");
        KnowledgeBase.Rules.Add(R40_9);
        R40_9.Premises.Add(new Fact(GENAGE_variable, GENAGE_domain.Values[1]));
        R40_9.Premises.Add(new Fact(MEMLVL_variable, MEMLVL_domain.Values[2]));
        R40_9.Premises.Add(new Fact(MSCLVL_variable, MSCLVL_domain.Values[0]));
        R40_9.Conclusions.Add((new Fact(QLTLVL_variable, QLTLVL_domain.Values[1])));
        R40_9.Description = string.Join(" И ", R40_9.Premises) + ", ТО " + string.Join(" И ", R40_9.Conclusions);

        var R41_1 = new Rule("R41_1", "");
        KnowledgeBase.Rules.Add(R41_1);
        R41_1.Premises.Add(new Fact(SEX_variable, SEX_domain.Values[1]));
        R41_1.Conclusions.Add((new Fact(GENAGE_variable, GENAGE_domain.Values[1])));
        R41_1.Description = string.Join(" И ", R41_1.Premises) + ", ТО " + string.Join(" И ", R41_1.Conclusions);

        var R41_2 = new Rule("R41_2", "");
        KnowledgeBase.Rules.Add(R41_2);
        R41_2.Premises.Add(new Fact(SEX_variable, SEX_domain.Values[0]));
        R41_2.Premises.Add(new Fact(AGE_variable, AGE_domain.Values[2]));
        R41_2.Conclusions.Add((new Fact(GENAGE_variable, GENAGE_domain.Values[1])));
        R41_2.Description = string.Join(" И ", R41_2.Premises) + ", ТО " + string.Join(" И ", R41_2.Conclusions);

        var R42_3 = new Rule("R42_3", "");
        KnowledgeBase.Rules.Add(R42_3);
        R42_3.Premises.Add(new Fact(SEX_variable, SEX_domain.Values[0]));
        R42_3.Premises.Add(new Fact(AGE_variable, AGE_domain.Values[0]));
        R42_3.Conclusions.Add((new Fact(GENAGE_variable, GENAGE_domain.Values[0])));
        R42_3.Description = string.Join(" И ", R42_3.Premises) + ", ТО " + string.Join(" И ", R42_3.Conclusions);

        var R42_4 = new Rule("R42_4", "");
        KnowledgeBase.Rules.Add(R42_4);
        R42_4.Premises.Add(new Fact(SEX_variable, SEX_domain.Values[0]));
        R42_4.Premises.Add(new Fact(AGE_variable, AGE_domain.Values[1]));
        R42_4.Conclusions.Add((new Fact(GENAGE_variable, GENAGE_domain.Values[0])));
        R42_4.Description = string.Join(" И ", R42_4.Premises) + ", ТО " + string.Join(" И ", R42_4.Conclusions);

        var R43 = new Rule("R43", "");
        KnowledgeBase.Rules.Add(R43);
        R43.Premises.Add(new Fact(POEMLVL_variable, POEMLVL_domain.Values[1]));
        R43.Premises.Add(new Fact(FACTLVL_variable, FACTLVL_domain.Values[1]));
        R43.Premises.Add(new Fact(DIARY_variable, DIARY_domain.Values[0]));
        R43.Conclusions.Add((new Fact(MEMLVL_variable, MEMLVL_domain.Values[2])));
        R43.Description = string.Join(" И ", R43.Premises) + ", ТО " + string.Join(" И ", R43.Conclusions);

        var R44 = new Rule("R44", "");
        KnowledgeBase.Rules.Add(R44);
        R44.Premises.Add(new Fact(POEMLVL_variable, POEMLVL_domain.Values[0]));
        R44.Premises.Add(new Fact(FACTLVL_variable, FACTLVL_domain.Values[0]));
        R44.Premises.Add(new Fact(DIARY_variable, DIARY_domain.Values[1]));
        R44.Conclusions.Add((new Fact(MEMLVL_variable, MEMLVL_domain.Values[0])));
        R44.Description = string.Join(" И ", R44.Premises) + ", ТО " + string.Join(" И ", R44.Conclusions);

        var R45_1 = new Rule("R45_1", "");
        KnowledgeBase.Rules.Add(R45_1);
        R45_1.Premises.Add(new Fact(POEMLVL_variable, POEMLVL_domain.Values[0]));
        R45_1.Premises.Add(new Fact(FACTLVL_variable, FACTLVL_domain.Values[0]));
        R45_1.Premises.Add(new Fact(DIARY_variable, DIARY_domain.Values[0]));
        R45_1.Conclusions.Add((new Fact(MEMLVL_variable, MEMLVL_domain.Values[1])));
        R45_1.Description = string.Join(" И ", R45_1.Premises) + ", ТО " + string.Join(" И ", R45_1.Conclusions);

        var R45_2 = new Rule("R45_2", "");
        KnowledgeBase.Rules.Add(R45_2);
        R45_2.Premises.Add(new Fact(POEMLVL_variable, POEMLVL_domain.Values[0]));
        R45_2.Premises.Add(new Fact(FACTLVL_variable, FACTLVL_domain.Values[1]));
        R45_2.Conclusions.Add((new Fact(MEMLVL_variable, MEMLVL_domain.Values[1])));
        R45_2.Description = string.Join(" И ", R45_2.Premises) + ", ТО " + string.Join(" И ", R45_2.Conclusions);

        var R45_3 = new Rule("R45_3", "");
        KnowledgeBase.Rules.Add(R45_3);
        R45_3.Premises.Add(new Fact(POEMLVL_variable, POEMLVL_domain.Values[1]));
        R45_3.Premises.Add(new Fact(FACTLVL_variable, FACTLVL_domain.Values[0]));
        R45_3.Conclusions.Add((new Fact(MEMLVL_variable, MEMLVL_domain.Values[1])));
        R45_3.Description = string.Join(" И ", R45_3.Premises) + ", ТО " + string.Join(" И ", R45_3.Conclusions);

        var R45_4 = new Rule("R45_4", "");
        KnowledgeBase.Rules.Add(R45_4);
        R45_4.Premises.Add(new Fact(POEMLVL_variable, POEMLVL_domain.Values[1]));
        R45_4.Premises.Add(new Fact(FACTLVL_variable, FACTLVL_domain.Values[1]));
        R45_4.Premises.Add(new Fact(DIARY_variable, DIARY_domain.Values[1]));
        R45_4.Conclusions.Add((new Fact(MEMLVL_variable, MEMLVL_domain.Values[1])));
        R45_4.Description = string.Join(" И ", R45_4.Premises) + ", ТО " + string.Join(" И ", R45_4.Conclusions);

        var R46_1 = new Rule("R46_1", "");
        KnowledgeBase.Rules.Add(R46_1);
        R46_1.Premises.Add(new Fact(VOCAL_variable, VOCAL_domain.Values[1]));
        R46_1.Conclusions.Add((new Fact(MSCLVL_variable, MSCLVL_domain.Values[1])));
        R46_1.Description = string.Join(" И ", R46_1.Premises) + ", ТО " + string.Join(" И ", R46_1.Conclusions);

        var R46_2 = new Rule("R46_2", "");
        KnowledgeBase.Rules.Add(R46_2);
        R46_2.Premises.Add(new Fact(HEARING_variable, HEARING_domain.Values[1]));
        R46_2.Conclusions.Add((new Fact(MSCLVL_variable, MSCLVL_domain.Values[1])));
        R46_2.Description = string.Join(" И ", R46_2.Premises) + ", ТО " + string.Join(" И ", R46_2.Conclusions);

        var R47 = new Rule("R47", "");
        KnowledgeBase.Rules.Add(R47);
        R47.Premises.Add(new Fact(VOCAL_variable, VOCAL_domain.Values[0]));
        R47.Premises.Add(new Fact(HEARING_variable, HEARING_domain.Values[0]));
        R47.Conclusions.Add((new Fact(MSCLVL_variable, MSCLVL_domain.Values[0])));
        R47.Description = string.Join(" И ", R47.Premises) + ", ТО " + string.Join(" И ", R47.Conclusions);
    }
}