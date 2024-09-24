// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> The language of the query. </summary>
    public readonly partial struct QueryLanguage : IEquatable<QueryLanguage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryLanguage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string EnUsValue = "en-us";
        private const string EnGbValue = "en-gb";
        private const string EnInValue = "en-in";
        private const string EnCaValue = "en-ca";
        private const string EnAuValue = "en-au";
        private const string FrFrValue = "fr-fr";
        private const string FrCaValue = "fr-ca";
        private const string DeDeValue = "de-de";
        private const string EsEsValue = "es-es";
        private const string EsMxValue = "es-mx";
        private const string ZhCnValue = "zh-cn";
        private const string ZhTwValue = "zh-tw";
        private const string PtBrValue = "pt-br";
        private const string PtPtValue = "pt-pt";
        private const string ItItValue = "it-it";
        private const string JaJpValue = "ja-jp";
        private const string KoKrValue = "ko-kr";
        private const string RuRuValue = "ru-ru";
        private const string CsCzValue = "cs-cz";
        private const string NlBeValue = "nl-be";
        private const string NlNlValue = "nl-nl";
        private const string HuHuValue = "hu-hu";
        private const string PlPlValue = "pl-pl";
        private const string SvSeValue = "sv-se";
        private const string TrTrValue = "tr-tr";
        private const string HiInValue = "hi-in";
        private const string ArSaValue = "ar-sa";
        private const string ArEgValue = "ar-eg";
        private const string ArMaValue = "ar-ma";
        private const string ArKwValue = "ar-kw";
        private const string ArJoValue = "ar-jo";
        private const string DaDkValue = "da-dk";
        private const string NoNoValue = "no-no";
        private const string BgBgValue = "bg-bg";
        private const string HrHrValue = "hr-hr";
        private const string HrBaValue = "hr-ba";
        private const string MsMyValue = "ms-my";
        private const string MsBnValue = "ms-bn";
        private const string SlSlValue = "sl-sl";
        private const string TaInValue = "ta-in";
        private const string ViVnValue = "vi-vn";
        private const string ElGrValue = "el-gr";
        private const string RoRoValue = "ro-ro";
        private const string IsIsValue = "is-is";
        private const string IdIdValue = "id-id";
        private const string ThThValue = "th-th";
        private const string LtLtValue = "lt-lt";
        private const string UkUaValue = "uk-ua";
        private const string LvLvValue = "lv-lv";
        private const string EtEeValue = "et-ee";
        private const string CaEsValue = "ca-es";
        private const string FiFiValue = "fi-fi";
        private const string SrBaValue = "sr-ba";
        private const string SrMeValue = "sr-me";
        private const string SrRsValue = "sr-rs";
        private const string SkSkValue = "sk-sk";
        private const string NbNoValue = "nb-no";
        private const string HyAmValue = "hy-am";
        private const string BnInValue = "bn-in";
        private const string EuEsValue = "eu-es";
        private const string GlEsValue = "gl-es";
        private const string GuInValue = "gu-in";
        private const string HeIlValue = "he-il";
        private const string GaIeValue = "ga-ie";
        private const string KnInValue = "kn-in";
        private const string MlInValue = "ml-in";
        private const string MrInValue = "mr-in";
        private const string FaAeValue = "fa-ae";
        private const string PaInValue = "pa-in";
        private const string TeInValue = "te-in";
        private const string UrPkValue = "ur-pk";

        /// <summary> Query language not specified. </summary>
        public static QueryLanguage None { get; } = new QueryLanguage(NoneValue);
        /// <summary> Query language value for English (United States). </summary>
        public static QueryLanguage EnUs { get; } = new QueryLanguage(EnUsValue);
        /// <summary> Query language value for English (Great Britain). </summary>
        public static QueryLanguage EnGb { get; } = new QueryLanguage(EnGbValue);
        /// <summary> Query language value for English (India). </summary>
        public static QueryLanguage EnIn { get; } = new QueryLanguage(EnInValue);
        /// <summary> Query language value for English (Canada). </summary>
        public static QueryLanguage EnCa { get; } = new QueryLanguage(EnCaValue);
        /// <summary> Query language value for English (Australia). </summary>
        public static QueryLanguage EnAu { get; } = new QueryLanguage(EnAuValue);
        /// <summary> Query language value for French (France). </summary>
        public static QueryLanguage FrFr { get; } = new QueryLanguage(FrFrValue);
        /// <summary> Query language value for French (Canada). </summary>
        public static QueryLanguage FrCa { get; } = new QueryLanguage(FrCaValue);
        /// <summary> Query language value for German (Germany). </summary>
        public static QueryLanguage DeDe { get; } = new QueryLanguage(DeDeValue);
        /// <summary> Query language value for Spanish (Spain). </summary>
        public static QueryLanguage EsEs { get; } = new QueryLanguage(EsEsValue);
        /// <summary> Query language value for Spanish (Mexico). </summary>
        public static QueryLanguage EsMx { get; } = new QueryLanguage(EsMxValue);
        /// <summary> Query language value for Chinese (China). </summary>
        public static QueryLanguage ZhCn { get; } = new QueryLanguage(ZhCnValue);
        /// <summary> Query language value for Chinese (Taiwan). </summary>
        public static QueryLanguage ZhTw { get; } = new QueryLanguage(ZhTwValue);
        /// <summary> Query language value for Portuguese (Brazil). </summary>
        public static QueryLanguage PtBr { get; } = new QueryLanguage(PtBrValue);
        /// <summary> Query language value for Portuguese (Portugal). </summary>
        public static QueryLanguage PtPt { get; } = new QueryLanguage(PtPtValue);
        /// <summary> Query language value for Italian (Italy). </summary>
        public static QueryLanguage ItIt { get; } = new QueryLanguage(ItItValue);
        /// <summary> Query language value for Japanese (Japan). </summary>
        public static QueryLanguage JaJp { get; } = new QueryLanguage(JaJpValue);
        /// <summary> Query language value for Korean (Korea). </summary>
        public static QueryLanguage KoKr { get; } = new QueryLanguage(KoKrValue);
        /// <summary> Query language value for Russian (Russia). </summary>
        public static QueryLanguage RuRu { get; } = new QueryLanguage(RuRuValue);
        /// <summary> Query language value for Czech (Czech Republic). </summary>
        public static QueryLanguage CsCz { get; } = new QueryLanguage(CsCzValue);
        /// <summary> Query language value for Dutch (Belgium). </summary>
        public static QueryLanguage NlBe { get; } = new QueryLanguage(NlBeValue);
        /// <summary> Query language value for Dutch (Netherlands). </summary>
        public static QueryLanguage NlNl { get; } = new QueryLanguage(NlNlValue);
        /// <summary> Query language value for Hungarian (Hungary). </summary>
        public static QueryLanguage HuHu { get; } = new QueryLanguage(HuHuValue);
        /// <summary> Query language value for Polish (Poland). </summary>
        public static QueryLanguage PlPl { get; } = new QueryLanguage(PlPlValue);
        /// <summary> Query language value for Swedish (Sweden). </summary>
        public static QueryLanguage SvSe { get; } = new QueryLanguage(SvSeValue);
        /// <summary> Query language value for Turkish (Turkey). </summary>
        public static QueryLanguage TrTr { get; } = new QueryLanguage(TrTrValue);
        /// <summary> Query language value for Hindi (India). </summary>
        public static QueryLanguage HiIn { get; } = new QueryLanguage(HiInValue);
        /// <summary> Query language value for Arabic (Saudi Arabia). </summary>
        public static QueryLanguage ArSa { get; } = new QueryLanguage(ArSaValue);
        /// <summary> Query language value for Arabic (Egypt). </summary>
        public static QueryLanguage ArEg { get; } = new QueryLanguage(ArEgValue);
        /// <summary> Query language value for Arabic (Morocco). </summary>
        public static QueryLanguage ArMa { get; } = new QueryLanguage(ArMaValue);
        /// <summary> Query language value for Arabic (Kuwait). </summary>
        public static QueryLanguage ArKw { get; } = new QueryLanguage(ArKwValue);
        /// <summary> Query language value for Arabic (Jordan). </summary>
        public static QueryLanguage ArJo { get; } = new QueryLanguage(ArJoValue);
        /// <summary> Query language value for Danish (Denmark). </summary>
        public static QueryLanguage DaDk { get; } = new QueryLanguage(DaDkValue);
        /// <summary> Query language value for Norwegian (Norway). </summary>
        public static QueryLanguage NoNo { get; } = new QueryLanguage(NoNoValue);
        /// <summary> Query language value for Bulgarian (Bulgaria). </summary>
        public static QueryLanguage BgBg { get; } = new QueryLanguage(BgBgValue);
        /// <summary> Query language value for Croatian (Croatia). </summary>
        public static QueryLanguage HrHr { get; } = new QueryLanguage(HrHrValue);
        /// <summary> Query language value for Croatian (Bosnia and Herzegovina). </summary>
        public static QueryLanguage HrBa { get; } = new QueryLanguage(HrBaValue);
        /// <summary> Query language value for Malay (Malaysia). </summary>
        public static QueryLanguage MsMy { get; } = new QueryLanguage(MsMyValue);
        /// <summary> Query language value for Malay (Brunei Darussalam). </summary>
        public static QueryLanguage MsBn { get; } = new QueryLanguage(MsBnValue);
        /// <summary> Query language value for Slovenian (Slovenia). </summary>
        public static QueryLanguage SlSl { get; } = new QueryLanguage(SlSlValue);
        /// <summary> Query language value for Tamil (India). </summary>
        public static QueryLanguage TaIn { get; } = new QueryLanguage(TaInValue);
        /// <summary> Query language value for Vietnamese (Viet Nam). </summary>
        public static QueryLanguage ViVn { get; } = new QueryLanguage(ViVnValue);
        /// <summary> Query language value for Greek (Greece). </summary>
        public static QueryLanguage ElGr { get; } = new QueryLanguage(ElGrValue);
        /// <summary> Query language value for Romanian (Romania). </summary>
        public static QueryLanguage RoRo { get; } = new QueryLanguage(RoRoValue);
        /// <summary> Query language value for Icelandic (Iceland). </summary>
        public static QueryLanguage IsIs { get; } = new QueryLanguage(IsIsValue);
        /// <summary> Query language value for Indonesian (Indonesia). </summary>
        public static QueryLanguage IdId { get; } = new QueryLanguage(IdIdValue);
        /// <summary> Query language value for Thai (Thailand). </summary>
        public static QueryLanguage ThTh { get; } = new QueryLanguage(ThThValue);
        /// <summary> Query language value for Lithuanian (Lithuania). </summary>
        public static QueryLanguage LtLt { get; } = new QueryLanguage(LtLtValue);
        /// <summary> Query language value for Ukrainian (Ukraine). </summary>
        public static QueryLanguage UkUa { get; } = new QueryLanguage(UkUaValue);
        /// <summary> Query language value for Latvian (Latvia). </summary>
        public static QueryLanguage LvLv { get; } = new QueryLanguage(LvLvValue);
        /// <summary> Query language value for Estonian (Estonia). </summary>
        public static QueryLanguage EtEe { get; } = new QueryLanguage(EtEeValue);
        /// <summary> Query language value for Catalan. </summary>
        public static QueryLanguage CaEs { get; } = new QueryLanguage(CaEsValue);
        /// <summary> Query language value for Finnish (Finland). </summary>
        public static QueryLanguage FiFi { get; } = new QueryLanguage(FiFiValue);
        /// <summary> Query language value for Serbian (Bosnia and Herzegovina). </summary>
        public static QueryLanguage SrBa { get; } = new QueryLanguage(SrBaValue);
        /// <summary> Query language value for Serbian (Montenegro). </summary>
        public static QueryLanguage SrMe { get; } = new QueryLanguage(SrMeValue);
        /// <summary> Query language value for Serbian (Serbia). </summary>
        public static QueryLanguage SrRs { get; } = new QueryLanguage(SrRsValue);
        /// <summary> Query language value for Slovak (Slovakia). </summary>
        public static QueryLanguage SkSk { get; } = new QueryLanguage(SkSkValue);
        /// <summary> Query language value for Norwegian (Norway). </summary>
        public static QueryLanguage NbNo { get; } = new QueryLanguage(NbNoValue);
        /// <summary> Query language value for Armenian (Armenia). </summary>
        public static QueryLanguage HyAm { get; } = new QueryLanguage(HyAmValue);
        /// <summary> Query language value for Bengali (India). </summary>
        public static QueryLanguage BnIn { get; } = new QueryLanguage(BnInValue);
        /// <summary> Query language value for Basque. </summary>
        public static QueryLanguage EuEs { get; } = new QueryLanguage(EuEsValue);
        /// <summary> Query language value for Galician. </summary>
        public static QueryLanguage GlEs { get; } = new QueryLanguage(GlEsValue);
        /// <summary> Query language value for Gujarati (India). </summary>
        public static QueryLanguage GuIn { get; } = new QueryLanguage(GuInValue);
        /// <summary> Query language value for Hebrew (Israel). </summary>
        public static QueryLanguage HeIl { get; } = new QueryLanguage(HeIlValue);
        /// <summary> Query language value for Irish (Ireland). </summary>
        public static QueryLanguage GaIe { get; } = new QueryLanguage(GaIeValue);
        /// <summary> Query language value for Kannada (India). </summary>
        public static QueryLanguage KnIn { get; } = new QueryLanguage(KnInValue);
        /// <summary> Query language value for Malayalam (India). </summary>
        public static QueryLanguage MlIn { get; } = new QueryLanguage(MlInValue);
        /// <summary> Query language value for Marathi (India). </summary>
        public static QueryLanguage MrIn { get; } = new QueryLanguage(MrInValue);
        /// <summary> Query language value for Persian (U.A.E.). </summary>
        public static QueryLanguage FaAe { get; } = new QueryLanguage(FaAeValue);
        /// <summary> Query language value for Punjabi (India). </summary>
        public static QueryLanguage PaIn { get; } = new QueryLanguage(PaInValue);
        /// <summary> Query language value for Telugu (India). </summary>
        public static QueryLanguage TeIn { get; } = new QueryLanguage(TeInValue);
        /// <summary> Query language value for Urdu (Pakistan). </summary>
        public static QueryLanguage UrPk { get; } = new QueryLanguage(UrPkValue);
        /// <summary> Determines if two <see cref="QueryLanguage"/> values are the same. </summary>
        public static bool operator ==(QueryLanguage left, QueryLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryLanguage"/> values are not the same. </summary>
        public static bool operator !=(QueryLanguage left, QueryLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryLanguage"/>. </summary>
        public static implicit operator QueryLanguage(string value) => new QueryLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryLanguage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
