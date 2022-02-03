using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "BrojNaIndeks", "ImePrezime", "TerminId" },
                values: new object[,]
                {
                    { 1000, "StudentPrva0", null },
                    { 2109, "StudentVtora109", null },
                    { 2110, "StudentVtora110", null },
                    { 2111, "StudentVtora111", null },
                    { 2112, "StudentVtora112", null },
                    { 2113, "StudentVtora113", null },
                    { 2114, "StudentVtora114", null },
                    { 2115, "StudentVtora115", null },
                    { 2116, "StudentVtora116", null },
                    { 2117, "StudentVtora117", null },
                    { 2118, "StudentVtora118", null },
                    { 2119, "StudentVtora119", null },
                    { 2108, "StudentVtora108", null },
                    { 2120, "StudentVtora120", null },
                    { 2122, "StudentVtora122", null },
                    { 2123, "StudentVtora123", null },
                    { 2124, "StudentVtora124", null },
                    { 2125, "StudentVtora125", null },
                    { 2126, "StudentVtora126", null },
                    { 2127, "StudentVtora127", null },
                    { 2128, "StudentVtora128", null },
                    { 2129, "StudentVtora129", null },
                    { 2130, "StudentVtora130", null },
                    { 2131, "StudentVtora131", null },
                    { 2132, "StudentVtora132", null },
                    { 2121, "StudentVtora121", null },
                    { 2107, "StudentVtora107", null },
                    { 2106, "StudentVtora106", null },
                    { 2105, "StudentVtora105", null },
                    { 2080, "StudentVtora80", null },
                    { 2081, "StudentVtora81", null },
                    { 2082, "StudentVtora82", null },
                    { 2083, "StudentVtora83", null },
                    { 2084, "StudentVtora84", null },
                    { 2085, "StudentVtora85", null },
                    { 2086, "StudentVtora86", null },
                    { 2087, "StudentVtora87", null },
                    { 2088, "StudentVtora88", null },
                    { 2089, "StudentVtora89", null },
                    { 2090, "StudentVtora90", null },
                    { 2091, "StudentVtora91", null },
                    { 2092, "StudentVtora92", null },
                    { 2093, "StudentVtora93", null },
                    { 2094, "StudentVtora94", null },
                    { 2095, "StudentVtora95", null },
                    { 2096, "StudentVtora96", null },
                    { 2097, "StudentVtora97", null },
                    { 2098, "StudentVtora98", null },
                    { 2099, "StudentVtora99", null },
                    { 2100, "StudentVtora100", null },
                    { 2101, "StudentVtora101", null },
                    { 2102, "StudentVtora102", null },
                    { 2103, "StudentVtora103", null },
                    { 2104, "StudentVtora104", null },
                    { 2133, "StudentVtora133", null },
                    { 2134, "StudentVtora134", null },
                    { 2135, "StudentVtora135", null },
                    { 2136, "StudentVtora136", null },
                    { 2166, "StudentVtora166", null },
                    { 2167, "StudentVtora167", null },
                    { 2168, "StudentVtora168", null },
                    { 2169, "StudentVtora169", null },
                    { 2170, "StudentVtora170", null },
                    { 2171, "StudentVtora171", null },
                    { 2172, "StudentVtora172", null },
                    { 2173, "StudentVtora173", null },
                    { 2174, "StudentVtora174", null },
                    { 2175, "StudentVtora175", null },
                    { 2176, "StudentVtora176", null },
                    { 2177, "StudentVtora177", null },
                    { 2178, "StudentVtora178", null },
                    { 2179, "StudentVtora179", null },
                    { 2180, "StudentVtora180", null },
                    { 2181, "StudentVtora181", null },
                    { 2182, "StudentVtora182", null },
                    { 2183, "StudentVtora183", null },
                    { 2184, "StudentVtora184", null },
                    { 2185, "StudentVtora185", null },
                    { 2186, "StudentVtora186", null },
                    { 2187, "StudentVtora187", null },
                    { 2188, "StudentVtora188", null },
                    { 2189, "StudentVtora189", null },
                    { 2190, "StudentVtora190", null },
                    { 2165, "StudentVtora165", null },
                    { 2079, "StudentVtora79", null },
                    { 2164, "StudentVtora164", null },
                    { 2162, "StudentVtora162", null },
                    { 2137, "StudentVtora137", null },
                    { 2138, "StudentVtora138", null },
                    { 2139, "StudentVtora139", null },
                    { 2140, "StudentVtora140", null },
                    { 2141, "StudentVtora141", null },
                    { 2142, "StudentVtora142", null },
                    { 2143, "StudentVtora143", null },
                    { 2144, "StudentVtora144", null },
                    { 2145, "StudentVtora145", null },
                    { 2146, "StudentVtora146", null },
                    { 2147, "StudentVtora147", null },
                    { 2148, "StudentVtora148", null },
                    { 2149, "StudentVtora149", null },
                    { 2150, "StudentVtora150", null },
                    { 2151, "StudentVtora151", null },
                    { 2152, "StudentVtora152", null },
                    { 2153, "StudentVtora153", null },
                    { 2154, "StudentVtora154", null },
                    { 2155, "StudentVtora155", null },
                    { 2156, "StudentVtora156", null },
                    { 2157, "StudentVtora157", null },
                    { 2158, "StudentVtora158", null },
                    { 2159, "StudentVtora159", null },
                    { 2160, "StudentVtora160", null },
                    { 2161, "StudentVtora161", null },
                    { 2163, "StudentVtora163", null },
                    { 2078, "StudentVtora78", null },
                    { 2077, "StudentVtora77", null },
                    { 2076, "StudentVtora76", null },
                    { 1493, "StudentPrva493", null },
                    { 1494, "StudentPrva494", null },
                    { 1495, "StudentPrva495", null },
                    { 1496, "StudentPrva496", null },
                    { 1497, "StudentPrva497", null },
                    { 1498, "StudentPrva498", null },
                    { 1499, "StudentPrva499", null },
                    { 2000, "StudentVtora0", null },
                    { 2001, "StudentVtora1", null },
                    { 2002, "StudentVtora2", null },
                    { 2003, "StudentVtora3", null },
                    { 2004, "StudentVtora4", null },
                    { 2005, "StudentVtora5", null },
                    { 2006, "StudentVtora6", null },
                    { 2007, "StudentVtora7", null },
                    { 2008, "StudentVtora8", null },
                    { 2009, "StudentVtora9", null },
                    { 2010, "StudentVtora10", null },
                    { 2011, "StudentVtora11", null },
                    { 2012, "StudentVtora12", null },
                    { 2013, "StudentVtora13", null },
                    { 2014, "StudentVtora14", null },
                    { 2015, "StudentVtora15", null },
                    { 2016, "StudentVtora16", null },
                    { 2017, "StudentVtora17", null },
                    { 1492, "StudentPrva492", null },
                    { 2018, "StudentVtora18", null },
                    { 1491, "StudentPrva491", null },
                    { 1489, "StudentPrva489", null },
                    { 1464, "StudentPrva464", null },
                    { 1465, "StudentPrva465", null },
                    { 1466, "StudentPrva466", null },
                    { 1467, "StudentPrva467", null },
                    { 1468, "StudentPrva468", null },
                    { 1469, "StudentPrva469", null },
                    { 1470, "StudentPrva470", null },
                    { 1471, "StudentPrva471", null },
                    { 1472, "StudentPrva472", null },
                    { 1473, "StudentPrva473", null },
                    { 1474, "StudentPrva474", null },
                    { 1475, "StudentPrva475", null },
                    { 1476, "StudentPrva476", null },
                    { 1477, "StudentPrva477", null },
                    { 1478, "StudentPrva478", null },
                    { 1479, "StudentPrva479", null },
                    { 1480, "StudentPrva480", null },
                    { 1481, "StudentPrva481", null },
                    { 1482, "StudentPrva482", null },
                    { 1483, "StudentPrva483", null },
                    { 1484, "StudentPrva484", null },
                    { 1485, "StudentPrva485", null },
                    { 1486, "StudentPrva486", null },
                    { 1487, "StudentPrva487", null },
                    { 1488, "StudentPrva488", null },
                    { 1490, "StudentPrva490", null },
                    { 2191, "StudentVtora191", null },
                    { 2019, "StudentVtora19", null },
                    { 2021, "StudentVtora21", null },
                    { 2051, "StudentVtora51", null },
                    { 2052, "StudentVtora52", null },
                    { 2053, "StudentVtora53", null },
                    { 2054, "StudentVtora54", null },
                    { 2055, "StudentVtora55", null },
                    { 2056, "StudentVtora56", null },
                    { 2057, "StudentVtora57", null },
                    { 2058, "StudentVtora58", null },
                    { 2059, "StudentVtora59", null },
                    { 2060, "StudentVtora60", null },
                    { 2061, "StudentVtora61", null },
                    { 2062, "StudentVtora62", null },
                    { 2063, "StudentVtora63", null },
                    { 2064, "StudentVtora64", null },
                    { 2065, "StudentVtora65", null },
                    { 2066, "StudentVtora66", null },
                    { 2067, "StudentVtora67", null },
                    { 2068, "StudentVtora68", null },
                    { 2069, "StudentVtora69", null },
                    { 2070, "StudentVtora70", null },
                    { 2071, "StudentVtora71", null },
                    { 2072, "StudentVtora72", null },
                    { 2073, "StudentVtora73", null },
                    { 2074, "StudentVtora74", null },
                    { 2075, "StudentVtora75", null },
                    { 2050, "StudentVtora50", null },
                    { 2020, "StudentVtora20", null },
                    { 2049, "StudentVtora49", null },
                    { 2047, "StudentVtora47", null },
                    { 2022, "StudentVtora22", null },
                    { 2023, "StudentVtora23", null },
                    { 2024, "StudentVtora24", null },
                    { 2025, "StudentVtora25", null },
                    { 2026, "StudentVtora26", null },
                    { 2027, "StudentVtora27", null },
                    { 2028, "StudentVtora28", null },
                    { 2029, "StudentVtora29", null },
                    { 2030, "StudentVtora30", null },
                    { 2031, "StudentVtora31", null },
                    { 2032, "StudentVtora32", null },
                    { 2033, "StudentVtora33", null },
                    { 2034, "StudentVtora34", null },
                    { 2035, "StudentVtora35", null },
                    { 2036, "StudentVtora36", null },
                    { 2037, "StudentVtora37", null },
                    { 2038, "StudentVtora38", null },
                    { 2039, "StudentVtora39", null },
                    { 2040, "StudentVtora40", null },
                    { 2041, "StudentVtora41", null },
                    { 2042, "StudentVtora42", null },
                    { 2043, "StudentVtora43", null },
                    { 2044, "StudentVtora44", null },
                    { 2045, "StudentVtora45", null },
                    { 2046, "StudentVtora46", null },
                    { 2048, "StudentVtora48", null },
                    { 2192, "StudentVtora192", null },
                    { 2193, "StudentVtora193", null },
                    { 2194, "StudentVtora194", null },
                    { 3090, "StudentTreta90", null },
                    { 3091, "StudentTreta91", null },
                    { 3092, "StudentTreta92", null },
                    { 3093, "StudentTreta93", null },
                    { 3094, "StudentTreta94", null },
                    { 3095, "StudentTreta95", null },
                    { 3096, "StudentTreta96", null },
                    { 3097, "StudentTreta97", null },
                    { 3098, "StudentTreta98", null },
                    { 3099, "StudentTreta99", null },
                    { 3100, "StudentTreta100", null },
                    { 3101, "StudentTreta101", null },
                    { 3102, "StudentTreta102", null },
                    { 3103, "StudentTreta103", null },
                    { 3104, "StudentTreta104", null },
                    { 3105, "StudentTreta105", null },
                    { 3106, "StudentTreta106", null },
                    { 3107, "StudentTreta107", null },
                    { 3108, "StudentTreta108", null },
                    { 3109, "StudentTreta109", null },
                    { 3110, "StudentTreta110", null },
                    { 3111, "StudentTreta111", null },
                    { 3112, "StudentTreta112", null },
                    { 3113, "StudentTreta113", null },
                    { 3114, "StudentTreta114", null },
                    { 3089, "StudentTreta89", null },
                    { 3115, "StudentTreta115", null },
                    { 3088, "StudentTreta88", null },
                    { 3086, "StudentTreta86", null },
                    { 3061, "StudentTreta61", null },
                    { 3062, "StudentTreta62", null },
                    { 3063, "StudentTreta63", null },
                    { 3064, "StudentTreta64", null },
                    { 3065, "StudentTreta65", null },
                    { 3066, "StudentTreta66", null },
                    { 3067, "StudentTreta67", null },
                    { 3068, "StudentTreta68", null },
                    { 3069, "StudentTreta69", null },
                    { 3070, "StudentTreta70", null },
                    { 3071, "StudentTreta71", null },
                    { 3072, "StudentTreta72", null },
                    { 3073, "StudentTreta73", null },
                    { 3074, "StudentTreta74", null },
                    { 3075, "StudentTreta75", null },
                    { 3076, "StudentTreta76", null },
                    { 3077, "StudentTreta77", null },
                    { 3078, "StudentTreta78", null },
                    { 3079, "StudentTreta79", null },
                    { 3080, "StudentTreta80", null },
                    { 3081, "StudentTreta81", null },
                    { 3082, "StudentTreta82", null },
                    { 3083, "StudentTreta83", null },
                    { 3084, "StudentTreta84", null },
                    { 3085, "StudentTreta85", null },
                    { 3087, "StudentTreta87", null },
                    { 3060, "StudentTreta60", null },
                    { 3116, "StudentTreta116", null },
                    { 3118, "StudentTreta118", null },
                    { 4023, "StudentCetvrta23", null },
                    { 4024, "StudentCetvrta24", null },
                    { 4025, "StudentCetvrta25", null },
                    { 4026, "StudentCetvrta26", null },
                    { 4027, "StudentCetvrta27", null },
                    { 4028, "StudentCetvrta28", null },
                    { 4029, "StudentCetvrta29", null },
                    { 4030, "StudentCetvrta30", null },
                    { 4031, "StudentCetvrta31", null },
                    { 4032, "StudentCetvrta32", null },
                    { 4033, "StudentCetvrta33", null },
                    { 4034, "StudentCetvrta34", null },
                    { 4035, "StudentCetvrta35", null },
                    { 4036, "StudentCetvrta36", null },
                    { 4037, "StudentCetvrta37", null },
                    { 4038, "StudentCetvrta38", null },
                    { 4039, "StudentCetvrta39", null },
                    { 4040, "StudentCetvrta40", null },
                    { 4041, "StudentCetvrta41", null },
                    { 4042, "StudentCetvrta42", null },
                    { 4043, "StudentCetvrta43", null },
                    { 4044, "StudentCetvrta44", null },
                    { 4045, "StudentCetvrta45", null },
                    { 4046, "StudentCetvrta46", null },
                    { 4047, "StudentCetvrta47", null },
                    { 4022, "StudentCetvrta22", null },
                    { 3117, "StudentTreta117", null },
                    { 4021, "StudentCetvrta21", null },
                    { 4019, "StudentCetvrta19", null },
                    { 3119, "StudentTreta119", null },
                    { 3120, "StudentTreta120", null },
                    { 3121, "StudentTreta121", null },
                    { 3122, "StudentTreta122", null },
                    { 3123, "StudentTreta123", null },
                    { 3124, "StudentTreta124", null },
                    { 4000, "StudentCetvrta0", null },
                    { 4001, "StudentCetvrta1", null },
                    { 4002, "StudentCetvrta2", null },
                    { 4003, "StudentCetvrta3", null },
                    { 4004, "StudentCetvrta4", null },
                    { 4005, "StudentCetvrta5", null },
                    { 4006, "StudentCetvrta6", null },
                    { 4007, "StudentCetvrta7", null },
                    { 4008, "StudentCetvrta8", null },
                    { 4009, "StudentCetvrta9", null },
                    { 4010, "StudentCetvrta10", null },
                    { 4011, "StudentCetvrta11", null },
                    { 4012, "StudentCetvrta12", null },
                    { 4013, "StudentCetvrta13", null },
                    { 4014, "StudentCetvrta14", null },
                    { 4015, "StudentCetvrta15", null },
                    { 4016, "StudentCetvrta16", null },
                    { 4017, "StudentCetvrta17", null },
                    { 4018, "StudentCetvrta18", null },
                    { 4020, "StudentCetvrta20", null },
                    { 1463, "StudentPrva463", null },
                    { 3059, "StudentTreta59", null },
                    { 3057, "StudentTreta57", null },
                    { 2224, "StudentVtora224", null },
                    { 2225, "StudentVtora225", null },
                    { 2226, "StudentVtora226", null },
                    { 2227, "StudentVtora227", null },
                    { 2228, "StudentVtora228", null },
                    { 2229, "StudentVtora229", null },
                    { 2230, "StudentVtora230", null },
                    { 2231, "StudentVtora231", null },
                    { 2232, "StudentVtora232", null },
                    { 2233, "StudentVtora233", null },
                    { 2234, "StudentVtora234", null },
                    { 2235, "StudentVtora235", null },
                    { 2236, "StudentVtora236", null },
                    { 2237, "StudentVtora237", null },
                    { 2238, "StudentVtora238", null },
                    { 2239, "StudentVtora239", null },
                    { 2240, "StudentVtora240", null },
                    { 2241, "StudentVtora241", null },
                    { 2242, "StudentVtora242", null },
                    { 2243, "StudentVtora243", null },
                    { 2244, "StudentVtora244", null },
                    { 2245, "StudentVtora245", null },
                    { 2246, "StudentVtora246", null },
                    { 2247, "StudentVtora247", null },
                    { 2248, "StudentVtora248", null },
                    { 2223, "StudentVtora223", null },
                    { 2249, "StudentVtora249", null },
                    { 2222, "StudentVtora222", null },
                    { 2220, "StudentVtora220", null },
                    { 2195, "StudentVtora195", null },
                    { 2196, "StudentVtora196", null },
                    { 2197, "StudentVtora197", null },
                    { 2198, "StudentVtora198", null },
                    { 2199, "StudentVtora199", null },
                    { 2200, "StudentVtora200", null },
                    { 2201, "StudentVtora201", null },
                    { 2202, "StudentVtora202", null },
                    { 2203, "StudentVtora203", null },
                    { 2204, "StudentVtora204", null },
                    { 2205, "StudentVtora205", null },
                    { 2206, "StudentVtora206", null },
                    { 2207, "StudentVtora207", null },
                    { 2208, "StudentVtora208", null },
                    { 2209, "StudentVtora209", null },
                    { 2210, "StudentVtora210", null },
                    { 2211, "StudentVtora211", null },
                    { 2212, "StudentVtora212", null },
                    { 2213, "StudentVtora213", null },
                    { 2214, "StudentVtora214", null },
                    { 2215, "StudentVtora215", null },
                    { 2216, "StudentVtora216", null },
                    { 2217, "StudentVtora217", null },
                    { 2218, "StudentVtora218", null },
                    { 2219, "StudentVtora219", null },
                    { 2221, "StudentVtora221", null },
                    { 3058, "StudentTreta58", null },
                    { 3000, "StudentTreta0", null },
                    { 3002, "StudentTreta2", null },
                    { 3032, "StudentTreta32", null },
                    { 3033, "StudentTreta33", null },
                    { 3034, "StudentTreta34", null },
                    { 3035, "StudentTreta35", null },
                    { 3036, "StudentTreta36", null },
                    { 3037, "StudentTreta37", null },
                    { 3038, "StudentTreta38", null },
                    { 3039, "StudentTreta39", null },
                    { 3040, "StudentTreta40", null },
                    { 3041, "StudentTreta41", null },
                    { 3042, "StudentTreta42", null },
                    { 3043, "StudentTreta43", null },
                    { 3044, "StudentTreta44", null },
                    { 3045, "StudentTreta45", null },
                    { 3046, "StudentTreta46", null },
                    { 3047, "StudentTreta47", null },
                    { 3048, "StudentTreta48", null },
                    { 3049, "StudentTreta49", null },
                    { 3050, "StudentTreta50", null },
                    { 3051, "StudentTreta51", null },
                    { 3052, "StudentTreta52", null },
                    { 3053, "StudentTreta53", null },
                    { 3054, "StudentTreta54", null },
                    { 3055, "StudentTreta55", null },
                    { 3056, "StudentTreta56", null },
                    { 3031, "StudentTreta31", null },
                    { 3001, "StudentTreta1", null },
                    { 3030, "StudentTreta30", null },
                    { 3028, "StudentTreta28", null },
                    { 3003, "StudentTreta3", null },
                    { 3004, "StudentTreta4", null },
                    { 3005, "StudentTreta5", null },
                    { 3006, "StudentTreta6", null },
                    { 3007, "StudentTreta7", null },
                    { 3008, "StudentTreta8", null },
                    { 3009, "StudentTreta9", null },
                    { 3010, "StudentTreta10", null },
                    { 3011, "StudentTreta11", null },
                    { 3012, "StudentTreta12", null },
                    { 3013, "StudentTreta13", null },
                    { 3014, "StudentTreta14", null },
                    { 3015, "StudentTreta15", null },
                    { 3016, "StudentTreta16", null },
                    { 3017, "StudentTreta17", null },
                    { 3018, "StudentTreta18", null },
                    { 3019, "StudentTreta19", null },
                    { 3020, "StudentTreta20", null },
                    { 3021, "StudentTreta21", null },
                    { 3022, "StudentTreta22", null },
                    { 3023, "StudentTreta23", null },
                    { 3024, "StudentTreta24", null },
                    { 3025, "StudentTreta25", null },
                    { 3026, "StudentTreta26", null },
                    { 3027, "StudentTreta27", null },
                    { 3029, "StudentTreta29", null },
                    { 4048, "StudentCetvrta48", null },
                    { 1462, "StudentPrva462", null },
                    { 1460, "StudentPrva460", null },
                    { 1146, "StudentPrva146", null },
                    { 1147, "StudentPrva147", null },
                    { 1148, "StudentPrva148", null },
                    { 1149, "StudentPrva149", null },
                    { 1150, "StudentPrva150", null },
                    { 1151, "StudentPrva151", null },
                    { 1152, "StudentPrva152", null },
                    { 1153, "StudentPrva153", null },
                    { 1154, "StudentPrva154", null },
                    { 1155, "StudentPrva155", null },
                    { 1156, "StudentPrva156", null },
                    { 1145, "StudentPrva145", null },
                    { 1157, "StudentPrva157", null },
                    { 1159, "StudentPrva159", null },
                    { 1160, "StudentPrva160", null },
                    { 1161, "StudentPrva161", null },
                    { 1162, "StudentPrva162", null },
                    { 1163, "StudentPrva163", null },
                    { 1164, "StudentPrva164", null },
                    { 1165, "StudentPrva165", null },
                    { 1166, "StudentPrva166", null },
                    { 1167, "StudentPrva167", null },
                    { 1168, "StudentPrva168", null },
                    { 1169, "StudentPrva169", null },
                    { 1158, "StudentPrva158", null },
                    { 1144, "StudentPrva144", null },
                    { 1143, "StudentPrva143", null },
                    { 1142, "StudentPrva142", null },
                    { 1117, "StudentPrva117", null },
                    { 1118, "StudentPrva118", null },
                    { 1119, "StudentPrva119", null },
                    { 1120, "StudentPrva120", null },
                    { 1121, "StudentPrva121", null },
                    { 1122, "StudentPrva122", null },
                    { 1123, "StudentPrva123", null },
                    { 1124, "StudentPrva124", null },
                    { 1125, "StudentPrva125", null },
                    { 1126, "StudentPrva126", null },
                    { 1127, "StudentPrva127", null },
                    { 1128, "StudentPrva128", null },
                    { 1129, "StudentPrva129", null },
                    { 1130, "StudentPrva130", null },
                    { 1131, "StudentPrva131", null },
                    { 1132, "StudentPrva132", null },
                    { 1133, "StudentPrva133", null },
                    { 1134, "StudentPrva134", null },
                    { 1135, "StudentPrva135", null },
                    { 1136, "StudentPrva136", null },
                    { 1137, "StudentPrva137", null },
                    { 1138, "StudentPrva138", null },
                    { 1139, "StudentPrva139", null },
                    { 1140, "StudentPrva140", null },
                    { 1141, "StudentPrva141", null },
                    { 1170, "StudentPrva170", null },
                    { 1171, "StudentPrva171", null },
                    { 1172, "StudentPrva172", null },
                    { 1173, "StudentPrva173", null },
                    { 1203, "StudentPrva203", null },
                    { 1204, "StudentPrva204", null },
                    { 1205, "StudentPrva205", null },
                    { 1206, "StudentPrva206", null },
                    { 1207, "StudentPrva207", null },
                    { 1208, "StudentPrva208", null },
                    { 1209, "StudentPrva209", null },
                    { 1210, "StudentPrva210", null },
                    { 1211, "StudentPrva211", null },
                    { 1212, "StudentPrva212", null },
                    { 1213, "StudentPrva213", null },
                    { 1214, "StudentPrva214", null },
                    { 1215, "StudentPrva215", null },
                    { 1216, "StudentPrva216", null },
                    { 1217, "StudentPrva217", null },
                    { 1218, "StudentPrva218", null },
                    { 1219, "StudentPrva219", null },
                    { 1220, "StudentPrva220", null },
                    { 1221, "StudentPrva221", null },
                    { 1222, "StudentPrva222", null },
                    { 1223, "StudentPrva223", null },
                    { 1224, "StudentPrva224", null },
                    { 1225, "StudentPrva225", null },
                    { 1226, "StudentPrva226", null },
                    { 1227, "StudentPrva227", null },
                    { 1202, "StudentPrva202", null },
                    { 1116, "StudentPrva116", null },
                    { 1201, "StudentPrva201", null },
                    { 1199, "StudentPrva199", null },
                    { 1174, "StudentPrva174", null },
                    { 1175, "StudentPrva175", null },
                    { 1176, "StudentPrva176", null },
                    { 1177, "StudentPrva177", null },
                    { 1178, "StudentPrva178", null },
                    { 1179, "StudentPrva179", null },
                    { 1180, "StudentPrva180", null },
                    { 1181, "StudentPrva181", null },
                    { 1182, "StudentPrva182", null },
                    { 1183, "StudentPrva183", null },
                    { 1184, "StudentPrva184", null },
                    { 1185, "StudentPrva185", null },
                    { 1186, "StudentPrva186", null },
                    { 1187, "StudentPrva187", null },
                    { 1188, "StudentPrva188", null },
                    { 1189, "StudentPrva189", null },
                    { 1190, "StudentPrva190", null },
                    { 1191, "StudentPrva191", null },
                    { 1192, "StudentPrva192", null },
                    { 1193, "StudentPrva193", null },
                    { 1194, "StudentPrva194", null },
                    { 1195, "StudentPrva195", null },
                    { 1196, "StudentPrva196", null },
                    { 1197, "StudentPrva197", null },
                    { 1198, "StudentPrva198", null },
                    { 1200, "StudentPrva200", null },
                    { 1115, "StudentPrva115", null },
                    { 1114, "StudentPrva114", null },
                    { 1113, "StudentPrva113", null },
                    { 1030, "StudentPrva30", null },
                    { 1031, "StudentPrva31", null },
                    { 1032, "StudentPrva32", null },
                    { 1033, "StudentPrva33", null },
                    { 1034, "StudentPrva34", null },
                    { 1035, "StudentPrva35", null },
                    { 1036, "StudentPrva36", null },
                    { 1037, "StudentPrva37", null },
                    { 1038, "StudentPrva38", null },
                    { 1039, "StudentPrva39", null },
                    { 1040, "StudentPrva40", null },
                    { 1041, "StudentPrva41", null },
                    { 1042, "StudentPrva42", null },
                    { 1043, "StudentPrva43", null },
                    { 1044, "StudentPrva44", null },
                    { 1045, "StudentPrva45", null },
                    { 1046, "StudentPrva46", null },
                    { 1047, "StudentPrva47", null },
                    { 1048, "StudentPrva48", null },
                    { 1049, "StudentPrva49", null },
                    { 1050, "StudentPrva50", null },
                    { 1051, "StudentPrva51", null },
                    { 1052, "StudentPrva52", null },
                    { 1053, "StudentPrva53", null },
                    { 1054, "StudentPrva54", null },
                    { 1029, "StudentPrva29", null },
                    { 1055, "StudentPrva55", null },
                    { 1028, "StudentPrva28", null },
                    { 1026, "StudentPrva26", null },
                    { 1001, "StudentPrva1", null },
                    { 1002, "StudentPrva2", null },
                    { 1003, "StudentPrva3", null },
                    { 1004, "StudentPrva4", null },
                    { 1005, "StudentPrva5", null },
                    { 1006, "StudentPrva6", null },
                    { 1007, "StudentPrva7", null },
                    { 1008, "StudentPrva8", null },
                    { 1009, "StudentPrva9", null },
                    { 1010, "StudentPrva10", null },
                    { 1011, "StudentPrva11", null },
                    { 1012, "StudentPrva12", null },
                    { 1013, "StudentPrva13", null },
                    { 1014, "StudentPrva14", null },
                    { 1015, "StudentPrva15", null },
                    { 1016, "StudentPrva16", null },
                    { 1017, "StudentPrva17", null },
                    { 1018, "StudentPrva18", null },
                    { 1019, "StudentPrva19", null },
                    { 1020, "StudentPrva20", null },
                    { 1021, "StudentPrva21", null },
                    { 1022, "StudentPrva22", null },
                    { 1023, "StudentPrva23", null },
                    { 1024, "StudentPrva24", null },
                    { 1025, "StudentPrva25", null },
                    { 1027, "StudentPrva27", null },
                    { 1228, "StudentPrva228", null },
                    { 1056, "StudentPrva56", null },
                    { 1058, "StudentPrva58", null },
                    { 1088, "StudentPrva88", null },
                    { 1089, "StudentPrva89", null },
                    { 1090, "StudentPrva90", null },
                    { 1091, "StudentPrva91", null },
                    { 1092, "StudentPrva92", null },
                    { 1093, "StudentPrva93", null },
                    { 1094, "StudentPrva94", null },
                    { 1095, "StudentPrva95", null },
                    { 1096, "StudentPrva96", null },
                    { 1097, "StudentPrva97", null },
                    { 1098, "StudentPrva98", null },
                    { 1099, "StudentPrva99", null },
                    { 1100, "StudentPrva100", null },
                    { 1101, "StudentPrva101", null },
                    { 1102, "StudentPrva102", null },
                    { 1103, "StudentPrva103", null },
                    { 1104, "StudentPrva104", null },
                    { 1105, "StudentPrva105", null },
                    { 1106, "StudentPrva106", null },
                    { 1107, "StudentPrva107", null },
                    { 1108, "StudentPrva108", null },
                    { 1109, "StudentPrva109", null },
                    { 1110, "StudentPrva110", null },
                    { 1111, "StudentPrva111", null },
                    { 1112, "StudentPrva112", null },
                    { 1087, "StudentPrva87", null },
                    { 1057, "StudentPrva57", null },
                    { 1086, "StudentPrva86", null },
                    { 1084, "StudentPrva84", null },
                    { 1059, "StudentPrva59", null },
                    { 1060, "StudentPrva60", null },
                    { 1061, "StudentPrva61", null },
                    { 1062, "StudentPrva62", null },
                    { 1063, "StudentPrva63", null },
                    { 1064, "StudentPrva64", null },
                    { 1065, "StudentPrva65", null },
                    { 1066, "StudentPrva66", null },
                    { 1067, "StudentPrva67", null },
                    { 1068, "StudentPrva68", null },
                    { 1069, "StudentPrva69", null },
                    { 1070, "StudentPrva70", null },
                    { 1071, "StudentPrva71", null },
                    { 1072, "StudentPrva72", null },
                    { 1073, "StudentPrva73", null },
                    { 1074, "StudentPrva74", null },
                    { 1075, "StudentPrva75", null },
                    { 1076, "StudentPrva76", null },
                    { 1077, "StudentPrva77", null },
                    { 1078, "StudentPrva78", null },
                    { 1079, "StudentPrva79", null },
                    { 1080, "StudentPrva80", null },
                    { 1081, "StudentPrva81", null },
                    { 1082, "StudentPrva82", null },
                    { 1083, "StudentPrva83", null },
                    { 1085, "StudentPrva85", null },
                    { 1229, "StudentPrva229", null },
                    { 1230, "StudentPrva230", null },
                    { 1231, "StudentPrva231", null },
                    { 1377, "StudentPrva377", null },
                    { 1378, "StudentPrva378", null },
                    { 1379, "StudentPrva379", null },
                    { 1380, "StudentPrva380", null }
                });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "BrojNaIndeks", "ImePrezime", "TerminId" },
                values: new object[,]
                {
                    { 1381, "StudentPrva381", null },
                    { 1382, "StudentPrva382", null },
                    { 1383, "StudentPrva383", null },
                    { 1384, "StudentPrva384", null },
                    { 1385, "StudentPrva385", null },
                    { 1386, "StudentPrva386", null },
                    { 1387, "StudentPrva387", null },
                    { 1388, "StudentPrva388", null },
                    { 1389, "StudentPrva389", null },
                    { 1390, "StudentPrva390", null },
                    { 1391, "StudentPrva391", null },
                    { 1392, "StudentPrva392", null },
                    { 1393, "StudentPrva393", null },
                    { 1394, "StudentPrva394", null },
                    { 1395, "StudentPrva395", null },
                    { 1396, "StudentPrva396", null },
                    { 1397, "StudentPrva397", null },
                    { 1398, "StudentPrva398", null },
                    { 1399, "StudentPrva399", null },
                    { 1400, "StudentPrva400", null },
                    { 1401, "StudentPrva401", null },
                    { 1376, "StudentPrva376", null },
                    { 1402, "StudentPrva402", null },
                    { 1375, "StudentPrva375", null },
                    { 1373, "StudentPrva373", null },
                    { 1348, "StudentPrva348", null },
                    { 1349, "StudentPrva349", null },
                    { 1350, "StudentPrva350", null },
                    { 1351, "StudentPrva351", null },
                    { 1352, "StudentPrva352", null },
                    { 1353, "StudentPrva353", null },
                    { 1354, "StudentPrva354", null },
                    { 1355, "StudentPrva355", null },
                    { 1356, "StudentPrva356", null },
                    { 1357, "StudentPrva357", null },
                    { 1358, "StudentPrva358", null },
                    { 1359, "StudentPrva359", null },
                    { 1360, "StudentPrva360", null },
                    { 1361, "StudentPrva361", null },
                    { 1362, "StudentPrva362", null },
                    { 1363, "StudentPrva363", null },
                    { 1364, "StudentPrva364", null },
                    { 1365, "StudentPrva365", null },
                    { 1366, "StudentPrva366", null },
                    { 1367, "StudentPrva367", null },
                    { 1368, "StudentPrva368", null },
                    { 1369, "StudentPrva369", null },
                    { 1370, "StudentPrva370", null },
                    { 1371, "StudentPrva371", null },
                    { 1372, "StudentPrva372", null },
                    { 1374, "StudentPrva374", null },
                    { 1347, "StudentPrva347", null },
                    { 1403, "StudentPrva403", null },
                    { 1405, "StudentPrva405", null },
                    { 1435, "StudentPrva435", null },
                    { 1436, "StudentPrva436", null },
                    { 1437, "StudentPrva437", null },
                    { 1438, "StudentPrva438", null },
                    { 1439, "StudentPrva439", null },
                    { 1440, "StudentPrva440", null },
                    { 1441, "StudentPrva441", null },
                    { 1442, "StudentPrva442", null },
                    { 1443, "StudentPrva443", null },
                    { 1444, "StudentPrva444", null },
                    { 1445, "StudentPrva445", null },
                    { 1446, "StudentPrva446", null },
                    { 1447, "StudentPrva447", null },
                    { 1448, "StudentPrva448", null },
                    { 1449, "StudentPrva449", null },
                    { 1450, "StudentPrva450", null },
                    { 1451, "StudentPrva451", null },
                    { 1452, "StudentPrva452", null },
                    { 1453, "StudentPrva453", null },
                    { 1454, "StudentPrva454", null },
                    { 1455, "StudentPrva455", null },
                    { 1456, "StudentPrva456", null },
                    { 1457, "StudentPrva457", null },
                    { 1458, "StudentPrva458", null },
                    { 1459, "StudentPrva459", null },
                    { 1434, "StudentPrva434", null },
                    { 1404, "StudentPrva404", null },
                    { 1433, "StudentPrva433", null },
                    { 1431, "StudentPrva431", null },
                    { 1406, "StudentPrva406", null },
                    { 1407, "StudentPrva407", null },
                    { 1408, "StudentPrva408", null },
                    { 1409, "StudentPrva409", null },
                    { 1410, "StudentPrva410", null },
                    { 1411, "StudentPrva411", null },
                    { 1412, "StudentPrva412", null },
                    { 1413, "StudentPrva413", null },
                    { 1414, "StudentPrva414", null },
                    { 1415, "StudentPrva415", null },
                    { 1416, "StudentPrva416", null },
                    { 1417, "StudentPrva417", null },
                    { 1418, "StudentPrva418", null },
                    { 1419, "StudentPrva419", null },
                    { 1420, "StudentPrva420", null },
                    { 1421, "StudentPrva421", null },
                    { 1422, "StudentPrva422", null },
                    { 1423, "StudentPrva423", null },
                    { 1424, "StudentPrva424", null },
                    { 1425, "StudentPrva425", null },
                    { 1426, "StudentPrva426", null },
                    { 1427, "StudentPrva427", null },
                    { 1428, "StudentPrva428", null },
                    { 1429, "StudentPrva429", null },
                    { 1430, "StudentPrva430", null },
                    { 1432, "StudentPrva432", null },
                    { 1461, "StudentPrva461", null },
                    { 1346, "StudentPrva346", null },
                    { 1344, "StudentPrva344", null },
                    { 1261, "StudentPrva261", null },
                    { 1262, "StudentPrva262", null },
                    { 1263, "StudentPrva263", null },
                    { 1264, "StudentPrva264", null },
                    { 1265, "StudentPrva265", null },
                    { 1266, "StudentPrva266", null },
                    { 1267, "StudentPrva267", null },
                    { 1268, "StudentPrva268", null },
                    { 1269, "StudentPrva269", null },
                    { 1270, "StudentPrva270", null },
                    { 1271, "StudentPrva271", null },
                    { 1272, "StudentPrva272", null },
                    { 1273, "StudentPrva273", null },
                    { 1274, "StudentPrva274", null },
                    { 1275, "StudentPrva275", null },
                    { 1276, "StudentPrva276", null },
                    { 1277, "StudentPrva277", null },
                    { 1278, "StudentPrva278", null },
                    { 1279, "StudentPrva279", null },
                    { 1280, "StudentPrva280", null },
                    { 1281, "StudentPrva281", null },
                    { 1282, "StudentPrva282", null },
                    { 1283, "StudentPrva283", null },
                    { 1284, "StudentPrva284", null },
                    { 1285, "StudentPrva285", null },
                    { 1260, "StudentPrva260", null },
                    { 1286, "StudentPrva286", null },
                    { 1259, "StudentPrva259", null },
                    { 1257, "StudentPrva257", null },
                    { 1232, "StudentPrva232", null },
                    { 1233, "StudentPrva233", null },
                    { 1234, "StudentPrva234", null },
                    { 1235, "StudentPrva235", null },
                    { 1236, "StudentPrva236", null },
                    { 1237, "StudentPrva237", null },
                    { 1238, "StudentPrva238", null },
                    { 1239, "StudentPrva239", null },
                    { 1240, "StudentPrva240", null },
                    { 1241, "StudentPrva241", null },
                    { 1242, "StudentPrva242", null },
                    { 1243, "StudentPrva243", null },
                    { 1244, "StudentPrva244", null },
                    { 1245, "StudentPrva245", null },
                    { 1246, "StudentPrva246", null },
                    { 1247, "StudentPrva247", null },
                    { 1248, "StudentPrva248", null },
                    { 1249, "StudentPrva249", null },
                    { 1250, "StudentPrva250", null },
                    { 1251, "StudentPrva251", null },
                    { 1252, "StudentPrva252", null },
                    { 1253, "StudentPrva253", null },
                    { 1254, "StudentPrva254", null },
                    { 1255, "StudentPrva255", null },
                    { 1256, "StudentPrva256", null },
                    { 1258, "StudentPrva258", null },
                    { 1345, "StudentPrva345", null },
                    { 1287, "StudentPrva287", null },
                    { 1289, "StudentPrva289", null },
                    { 1319, "StudentPrva319", null },
                    { 1320, "StudentPrva320", null },
                    { 1321, "StudentPrva321", null },
                    { 1322, "StudentPrva322", null },
                    { 1323, "StudentPrva323", null },
                    { 1324, "StudentPrva324", null },
                    { 1325, "StudentPrva325", null },
                    { 1326, "StudentPrva326", null },
                    { 1327, "StudentPrva327", null },
                    { 1328, "StudentPrva328", null },
                    { 1329, "StudentPrva329", null },
                    { 1330, "StudentPrva330", null },
                    { 1331, "StudentPrva331", null },
                    { 1332, "StudentPrva332", null },
                    { 1333, "StudentPrva333", null },
                    { 1334, "StudentPrva334", null },
                    { 1335, "StudentPrva335", null },
                    { 1336, "StudentPrva336", null },
                    { 1337, "StudentPrva337", null },
                    { 1338, "StudentPrva338", null },
                    { 1339, "StudentPrva339", null },
                    { 1340, "StudentPrva340", null },
                    { 1341, "StudentPrva341", null },
                    { 1342, "StudentPrva342", null },
                    { 1343, "StudentPrva343", null },
                    { 1318, "StudentPrva318", null },
                    { 1288, "StudentPrva288", null },
                    { 1317, "StudentPrva317", null },
                    { 1315, "StudentPrva315", null },
                    { 1290, "StudentPrva290", null },
                    { 1291, "StudentPrva291", null },
                    { 1292, "StudentPrva292", null },
                    { 1293, "StudentPrva293", null },
                    { 1294, "StudentPrva294", null },
                    { 1295, "StudentPrva295", null },
                    { 1296, "StudentPrva296", null },
                    { 1297, "StudentPrva297", null },
                    { 1298, "StudentPrva298", null },
                    { 1299, "StudentPrva299", null },
                    { 1300, "StudentPrva300", null },
                    { 1301, "StudentPrva301", null },
                    { 1302, "StudentPrva302", null },
                    { 1303, "StudentPrva303", null },
                    { 1304, "StudentPrva304", null },
                    { 1305, "StudentPrva305", null },
                    { 1306, "StudentPrva306", null },
                    { 1307, "StudentPrva307", null },
                    { 1308, "StudentPrva308", null },
                    { 1309, "StudentPrva309", null },
                    { 1310, "StudentPrva310", null },
                    { 1311, "StudentPrva311", null },
                    { 1312, "StudentPrva312", null },
                    { 1313, "StudentPrva313", null },
                    { 1314, "StudentPrva314", null },
                    { 1316, "StudentPrva316", null },
                    { 4049, "StudentCetvrta49", null }
                });

            migrationBuilder.InsertData(
                table: "StudentiPolagaatPredmeti",
                columns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                values: new object[,]
                {
                    { 1000, "F18L1S023" },
                    { 2131, "F18L2W046" },
                    { 2131, "F18L2S100" },
                    { 2131, "F18L2S017" },
                    { 2132, "F18L2S124" },
                    { 2133, "F18L2S099" },
                    { 2133, "F18L2W140" },
                    { 2134, "F18L2W046" },
                    { 2134, "F18L2S097" },
                    { 2135, "F18L2S124" },
                    { 2135, "F18L2W167" },
                    { 2135, "F18L2W067" },
                    { 2135, "F18L2S082" },
                    { 2136, "F18L3S010" },
                    { 2137, "F18L2W140" },
                    { 2138, "F18L2W067" },
                    { 2131, "F18L2W001" },
                    { 2130, "F18L2W067" },
                    { 2130, "F18L2S082" },
                    { 2130, "F18L2S110" },
                    { 2125, "F18L2S100" },
                    { 2126, "F18L2S029" },
                    { 2126, "F18L3S010" },
                    { 2126, "F18L2W104" },
                    { 2126, "F18L2W067" },
                    { 2127, "F18L2S119" },
                    { 2127, "F18L2W046" },
                    { 2138, "F18L2S017" },
                    { 2127, "F18L1W007" },
                    { 2127, "F18L2W001" },
                    { 2128, "F18L2S084" },
                    { 2128, "F18L2S030" },
                    { 2129, "F18L2S099" },
                    { 2129, "F18L2S119" },
                    { 2129, "F18L2S097" },
                    { 2130, "F18L2S100" },
                    { 2127, "F18L1S052" },
                    { 2125, "F18L2S097" },
                    { 2138, "F18L2S029" },
                    { 2140, "F18L2W104" },
                    { 2147, "F18L2S017" },
                    { 2147, "F18L3S010" },
                    { 2147, "F18L2W104" },
                    { 2148, "F18L2S097" },
                    { 2148, "F18L2S030" },
                    { 2148, "F18L2S119" },
                    { 2148, "F18L2W001" },
                    { 2149, "F18L2W109" },
                    { 2149, "F18L2W046" },
                    { 2149, "F18L2S030" },
                    { 2150, "F18L2W001" },
                    { 2150, "F18L2S124" },
                    { 2151, "F18L2S082" },
                    { 2152, "F18L2S124" },
                    { 2153, "F18L2W109" },
                    { 2147, "F18L2W046" },
                    { 2146, "F18L2S082" },
                    { 2146, "F18L2W104" },
                    { 2146, "F18L2S017" },
                    { 2140, "F18L2S100" },
                    { 2140, "F18L2S099" },
                    { 2140, "F18L2W046" },
                    { 2141, "F18L2S119" },
                    { 2141, "F18L2S097" },
                    { 2141, "F18L2S082" },
                    { 2141, "F18L3S010" },
                    { 2139, "F18L2W046" },
                    { 2142, "F18L2W104" },
                    { 2143, "F18L2S119" },
                    { 2144, "F18L2S002" },
                    { 2144, "F18L2W167" },
                    { 2144, "F18L2W140" },
                    { 2145, "F18L2S119" },
                    { 2145, "F18L2W104" },
                    { 2146, "F18L2W001" },
                    { 2142, "F18L2S030" },
                    { 2125, "F18L2S099" },
                    { 2125, "F18L2S002" },
                    { 2124, "F18L3S010" },
                    { 2109, "F18L2S097" },
                    { 2109, "F18L2S084" },
                    { 2109, "F18L3S010" },
                    { 2110, "F18L2S124" },
                    { 2111, "F18L2W046" },
                    { 2111, "F18L2W104" },
                    { 2111, "F18L2W001" },
                    { 2112, "F18L2W001" },
                    { 2112, "F18L2S002" },
                    { 2113, "F18L2S030" },
                    { 2113, "F18L2S099" },
                    { 2113, "F18L2S110" },
                    { 2114, "F18L2S097" },
                    { 2114, "F18L2W167" },
                    { 2114, "F18L2W109" },
                    { 2108, "F18L2S100" },
                    { 2108, "F18L2S029" },
                    { 2107, "F18L2S124" },
                    { 2107, "F18L2S100" },
                    { 2106, "F18L3S010" },
                    { 2106, "F18L2W046" },
                    { 2106, "F18L1S023" },
                    { 2106, "F18L1W070" },
                    { 2106, "F18L1S120" },
                    { 2106, "F18L1S016" },
                    { 2106, "F18L1S013" },
                    { 2115, "F18L2W046" },
                    { 2106, "F18L2W006" },
                    { 2107, "F18L1S016" },
                    { 2107, "F18L2S119" },
                    { 2107, "F18L1W007" },
                    { 2107, "F18L2S097" },
                    { 2107, "F18L2W001" },
                    { 2107, "F18L1S116" },
                    { 2107, "F18L1W020" },
                    { 2107, "F18L2S099" },
                    { 2115, "F18L2W104" },
                    { 2116, "F18L3S010" },
                    { 2116, "F18L2S029" },
                    { 2121, "F18L2S082" },
                    { 2121, "F18L2W140" },
                    { 2121, "F18L1W007" },
                    { 2121, "F18L1W033" },
                    { 2122, "F18L2S119" },
                    { 2122, "F18L2W067" },
                    { 2122, "F18L2S002" },
                    { 2121, "F18L1S013" },
                    { 2123, "F18L2S100" },
                    { 2123, "F18L2S030" },
                    { 2123, "F18L2S119" },
                    { 2124, "F18L2W104" },
                    { 2124, "F18L2W001" },
                    { 2124, "F18L1W007" },
                    { 2124, "F18L1W041" },
                    { 2124, "F18L2S097" },
                    { 2123, "F18L2S124" },
                    { 2153, "F18L2S099" },
                    { 2120, "F18L2W167" },
                    { 2119, "F18L2S110" },
                    { 2116, "F18L2W046" },
                    { 2116, "F18L2W109" },
                    { 2117, "F18L2S099" },
                    { 2117, "F18L2S082" },
                    { 2117, "F18L2S110" },
                    { 2117, "F18L2S097" },
                    { 2117, "F18L2S119" },
                    { 2120, "F18L2W140" },
                    { 2117, "F18L1W031" },
                    { 2117, "F18L1S045" },
                    { 2117, "F18L2S124" },
                    { 2117, "F18L1W033" },
                    { 2118, "F18L2W104" },
                    { 2119, "F18L2S029" },
                    { 2119, "F18L2W167" },
                    { 2119, "F18L2S084" },
                    { 2117, "F18L2W167" },
                    { 2154, "F18L2S084" },
                    { 2154, "F18L2S110" },
                    { 2154, "F18L2W140" },
                    { 2190, "F18L2S100" },
                    { 2190, "F18L2S002" },
                    { 2190, "F18L2S097" },
                    { 2191, "F18L2W140" },
                    { 2191, "F18L2S097" },
                    { 2191, "F18L2W167" },
                    { 2192, "F18L2S099" },
                    { 2193, "F18L2W109" },
                    { 2193, "F18L2S099" },
                    { 2193, "F18L2S002" },
                    { 2193, "F18L3S010" },
                    { 2194, "F18L2S084" },
                    { 2195, "F18L2W167" },
                    { 2195, "F18L2S100" },
                    { 2195, "F18L1S015" },
                    { 2190, "F18L2S124" },
                    { 2189, "F18L2S082" },
                    { 2189, "F18L3S010" },
                    { 2189, "F18L2W104" },
                    { 2184, "F18L2W046" },
                    { 2184, "F18L1W005" },
                    { 2184, "F18L1S116" },
                    { 2184, "F18L1W070" },
                    { 2185, "F18L2S097" },
                    { 2185, "F18L2S084" },
                    { 2185, "F18L2S100" },
                    { 2195, "F18L3S010" },
                    { 2186, "F18L2W046" },
                    { 2187, "F18L2S082" },
                    { 2187, "F18L3S010" },
                    { 2187, "F18L2W006" },
                    { 2187, "F18L2S099" },
                    { 2188, "F18L2S097" },
                    { 2188, "F18L2S124" },
                    { 2188, "F18L2S110" },
                    { 2186, "F18L2S029" },
                    { 2195, "F18L1W031" },
                    { 2196, "F18L2S097" },
                    { 2196, "F18L2W046" },
                    { 2201, "F18L2S029" },
                    { 2201, "F18L2W006" },
                    { 2202, "F18L2S119" },
                    { 2202, "F18L2S029" },
                    { 2203, "F18L2S100" },
                    { 2203, "F18L2S110" },
                    { 2204, "F18L2S084" },
                    { 2201, "F18L2S097" },
                    { 2204, "F18L2S097" },
                    { 2205, "F18L2S124" },
                    { 2205, "F18L2W067" },
                    { 2205, "F18L2W104" },
                    { 2206, "F18L2W104" },
                    { 2206, "F18L2W167" },
                    { 2207, "F18L2S017" },
                    { 2207, "F18L2W104" },
                    { 2204, "F18L2W167" },
                    { 2184, "F18L2S124" },
                    { 2201, "F18L2S124" },
                    { 2200, "F18L2W104" },
                    { 2196, "F18L2W001" },
                    { 2196, "F18L2W104" },
                    { 2197, "F18L1S023" },
                    { 2197, "F18L1S120" },
                    { 2197, "F18L1S013" },
                    { 2197, "F18L2S097" },
                    { 2197, "F18L1S003" },
                    { 2200, "F18L2S084" },
                    { 2197, "F18L1S052" },
                    { 2197, "F18L2S124" },
                    { 2198, "F18L2W140" },
                    { 2198, "F18L2S029" },
                    { 2199, "F18L2W006" },
                    { 2199, "F18L2S084" },
                    { 2199, "F18L2W046" },
                    { 2200, "F18L2S124" },
                    { 2197, "F18L1S032" },
                    { 2106, "F18L1W041" },
                    { 2184, "F18L2W104" },
                    { 2184, "F18L2S110" },
                    { 2163, "F18L2S082" },
                    { 2164, "F18L3S010" },
                    { 2165, "F18L2S100" },
                    { 2165, "F18L2W109" },
                    { 2166, "F18L2S119" },
                    { 2166, "F18L2S099" },
                    { 2167, "F18L2S017" },
                    { 2168, "F18L2S097" },
                    { 2168, "F18L2S110" },
                    { 2169, "F18L1W031" },
                    { 2169, "F18L2W140" },
                    { 2169, "F18L2S017" },
                    { 2169, "F18L1S015" },
                    { 2169, "F18L2S119" },
                    { 2170, "F18L2W006" },
                    { 2163, "F18L2S017" },
                    { 2163, "F18L2W046" },
                    { 2162, "F18L2W167" },
                    { 2161, "F18L2S002" },
                    { 2154, "F18L2W046" },
                    { 2155, "F18L2W109" },
                    { 2155, "F18L2W001" },
                    { 2155, "F18L2S084" },
                    { 2156, "F18L2W109" },
                    { 2156, "F18L2W104" },
                    { 2157, "F18L2W167" },
                    { 2170, "F18L2S099" },
                    { 2158, "F18L2W104" },
                    { 2159, "F18L2S100" },
                    { 2159, "F18L2S084" },
                    { 2159, "F18L2S017" },
                    { 2160, "F18L2S082" },
                    { 2160, "F18L3S010" },
                    { 2161, "F18L2W109" },
                    { 2161, "F18L2S029" },
                    { 2158, "F18L2S119" },
                    { 2171, "F18L2S002" },
                    { 2171, "F18L3S010" },
                    { 2171, "F18L2W001" },
                    { 2177, "F18L2S097" },
                    { 2178, "F18L2S097" },
                    { 2179, "F18L2S017" },
                    { 2179, "F18L2S029" },
                    { 2179, "F18L2S099" },
                    { 2180, "F18L2S100" },
                    { 2180, "F18L2W109" },
                    { 2177, "F18L3S010" },
                    { 2180, "F18L2S110" },
                    { 2181, "F18L2W001" },
                    { 2181, "F18L2S029" },
                    { 2181, "F18L2S002" },
                    { 2182, "F18L2W140" },
                    { 2183, "F18L2S097" },
                    { 2184, "F18L1S120" },
                    { 2184, "F18L1W049" },
                    { 2181, "F18L2S097" },
                    { 2184, "F18L1S026" },
                    { 2177, "F18L2W109" },
                    { 2176, "F18L2W167" },
                    { 2171, "F18L2S119" },
                    { 2172, "F18L2S082" },
                    { 2172, "F18L2W109" },
                    { 2172, "F18L2W167" },
                    { 2173, "F18L2S002" },
                    { 2173, "F18L3S010" },
                    { 2173, "F18L2S029" },
                    { 2177, "F18L2W067" },
                    { 2173, "F18L2S099" },
                    { 2175, "F18L2S097" },
                    { 2176, "F18L1S023" },
                    { 2176, "F18L2W001" },
                    { 2176, "F18L2S110" },
                    { 2176, "F18L1S116" },
                    { 2176, "F18L2S099" },
                    { 2176, "F18L2S002" },
                    { 2174, "F18L2W001" },
                    { 2106, "F18L1S034" },
                    { 2105, "F18L2S099" },
                    { 2104, "F18L2S110" },
                    { 2037, "F18L2S100" },
                    { 2037, "F18L2W046" },
                    { 2037, "F18L2W104" },
                    { 2037, "F18L1W020" },
                    { 2037, "F18L1S032" },
                    { 2037, "F18L1S003" },
                    { 2037, "F18L2S099" },
                    { 2038, "F18L2S029" },
                    { 2038, "F18L2S082" },
                    { 2039, "F18L2S097" },
                    { 2040, "F18L2S002" },
                    { 2041, "F18L2W140" },
                    { 2042, "F18L2W167" },
                    { 2042, "F18L3S010" },
                    { 2042, "F18L2S100" },
                    { 2037, "F18L2S002" },
                    { 2036, "F18L2S099" },
                    { 2035, "F18L2S017" },
                    { 2034, "F18L1S034" },
                    { 2033, "F18L1S003" },
                    { 2033, "F18L1W011" },
                    { 2033, "F18L2W001" },
                    { 2033, "F18L1W041" },
                    { 2033, "F18L2W067" },
                    { 2033, "F18L2S124" },
                    { 2033, "F18L1W033" },
                    { 2043, "F18L2S119" },
                    { 2033, "F18L2S119" },
                    { 2033, "F18L1W020" },
                    { 2033, "F18L1S045" },
                    { 2034, "F18L1W005" },
                    { 2034, "F18L1S032" },
                    { 2034, "F18L2S124" },
                    { 2034, "F18L1W041" },
                    { 2034, "F18L2S110" },
                    { 2033, "F18L2S097" },
                    { 2043, "F18L2S002" },
                    { 2043, "F18L2S084" },
                    { 2043, "F18L2W104" },
                    { 2048, "F18L2S002" },
                    { 2048, "F18L2W140" },
                    { 2048, "F18L2W167" },
                    { 2048, "F18L2S084" },
                    { 2049, "F18L2S100" },
                    { 2050, "F18L2W046" },
                    { 2050, "F18L2S029" },
                    { 2047, "F18L2S124" },
                    { 2050, "F18L2W140" },
                    { 2051, "F18L2S097" },
                    { 2051, "F18L2S002" },
                    { 2051, "F18L2W109" },
                    { 2051, "F18L2W046" },
                    { 2052, "F18L2S124" },
                    { 2053, "F18L2S110" },
                    { 2053, "F18L2W167" },
                    { 2050, "F18L2W006" },
                    { 2032, "F18L2S119" },
                    { 2046, "F18L2W167" },
                    { 2046, "F18L1W031" },
                    { 2044, "F18L2W046" },
                    { 2044, "F18L2S124" },
                    { 2044, "F18L2S082" },
                    { 2044, "F18L2S119" },
                    { 2045, "F18L2W104" },
                    { 2045, "F18L2W067" },
                    { 2045, "F18L2W006" },
                    { 2046, "F18L2S124" },
                    { 2045, "F18L2S084" },
                    { 2046, "F18L1W070" },
                    { 2046, "F18L1S023" },
                    { 2046, "F18L2S030" },
                    { 2046, "F18L1W033" },
                    { 2046, "F18L1S015" },
                    { 2046, "F18L1S045" },
                    { 2046, "F18L1W007" },
                    { 2046, "F18L1S003" },
                    { 2053, "F18L2S029" },
                    { 2032, "F18L2W104" },
                    { 2031, "F18L2W104" },
                    { 2011, "F18L2S110" },
                    { 2011, "F18L2S124" },
                    { 2012, "F18L2S084" },
                    { 2013, "F18L2S082" },
                    { 2013, "F18L2W140" },
                    { 2013, "F18L2W046" },
                    { 2013, "F18L2S084" },
                    { 2013, "F18L1W007" },
                    { 2013, "F18L2S100" },
                    { 2013, "F18L1W020" },
                    { 2013, "F18L2S017" },
                    { 2013, "F18L1S120" },
                    { 2014, "F18L2S110" },
                    { 2014, "F18L2S030" },
                    { 2014, "F18L2W109" },
                    { 2011, "F18L2S030" },
                    { 2011, "F18L2S119" },
                    { 2010, "F18L2W104" },
                    { 2010, "F18L3S010" },
                    { 2004, "F18L2S100" },
                    { 2004, "F18L2W046" },
                    { 2005, "F18L2W140" },
                    { 2005, "F18L3S010" },
                    { 2006, "F18L2S100" },
                    { 2006, "F18L2W104" },
                    { 2007, "F18L2S082" },
                    { 2014, "F18L2W067" },
                    { 2007, "F18L3S010" },
                    { 2007, "F18L2S110" },
                    { 2008, "F18L2W109" },
                    { 2008, "F18L2S084" },
                    { 2008, "F18L2S082" },
                    { 2009, "F18L2W167" },
                    { 2009, "F18L2W006" },
                    { 2010, "F18L2S082" },
                    { 2007, "F18L2S099" },
                    { 2015, "F18L2S099" },
                    { 2015, "F18L2S119" },
                    { 2016, "F18L2W109" },
                    { 2026, "F18L2W001" },
                    { 2026, "F18L2W006" },
                    { 2027, "F18L2S100" },
                    { 2027, "F18L2W104" },
                    { 2027, "F18L2W006" },
                    { 2028, "F18L2W109" },
                    { 2028, "F18L2S017" },
                    { 2025, "F18L2W140" },
                    { 2029, "F18L1S032" },
                    { 2029, "F18L1S013" },
                    { 2029, "F18L2S110" },
                    { 2029, "F18L2S124" },
                    { 2029, "F18L1W070" },
                    { 2029, "F18L2S100" },
                    { 2029, "F18L2W067" },
                    { 2030, "F18L2S082" },
                    { 2029, "F18L2S029" },
                    { 2032, "F18L2S097" },
                    { 2024, "F18L2W167" },
                    { 2023, "F18L2W109" },
                    { 2016, "F18L2S030" },
                    { 2016, "F18L2W104" },
                    { 2016, "F18L2W001" },
                    { 2017, "F18L2W046" },
                    { 2018, "F18L3S010" },
                    { 2019, "F18L2S029" },
                    { 2020, "F18L2S110" },
                    { 2024, "F18L2W109" },
                    { 2021, "F18L2S084" },
                    { 2021, "F18L2S110" },
                    { 2021, "F18L2W167" },
                    { 2022, "F18L2S002" },
                    { 2022, "F18L2W067" },
                    { 2022, "F18L2W046" },
                    { 2022, "F18L2S097" },
                    { 2023, "F18L2W167" },
                    { 2021, "F18L2S124" },
                    { 2207, "F18L2W006" },
                    { 2054, "F18L1S116" },
                    { 2054, "F18L1W070" },
                    { 2086, "F18L2W006" },
                    { 2087, "F18L2S084" },
                    { 2087, "F18L2W006" },
                    { 2087, "F18L2S110" },
                    { 2088, "F18L1W011" },
                    { 2088, "F18L1W033" },
                    { 2088, "F18L1S120" },
                    { 2088, "F18L1S052" },
                    { 2088, "F18L1S016" },
                    { 2088, "F18L1S116" },
                    { 2088, "F18L2S084" },
                    { 2088, "F18L2S017" },
                    { 2088, "F18L1W070" },
                    { 2088, "F18L1S034" },
                    { 2089, "F18L2W001" },
                    { 2086, "F18L2S124" },
                    { 2085, "F18L2S100" },
                    { 2084, "F18L1W070" },
                    { 2084, "F18L1S015" },
                    { 2080, "F18L2W109" },
                    { 2080, "F18L2S082" },
                    { 2080, "F18L2W104" },
                    { 2080, "F18L2S099" },
                    { 2081, "F18L2S082" },
                    { 2081, "F18L2S017" },
                    { 2081, "F18L2W140" },
                    { 2090, "F18L2S017" },
                    { 2082, "F18L2W109" },
                    { 2083, "F18L2W167" },
                    { 2083, "F18L2S084" },
                    { 2083, "F18L2W046" },
                    { 2084, "F18L1S026" },
                    { 2084, "F18L1S034" },
                    { 2084, "F18L1W049" },
                    { 2084, "F18L3S010" },
                    { 2082, "F18L2S100" },
                    { 2091, "F18L2W046" },
                    { 2091, "F18L2S030" },
                    { 2092, "F18L2W167" },
                    { 2100, "F18L2W167" },
                    { 2100, "F18L2S029" },
                    { 2100, "F18L1S120" },
                    { 2100, "F18L2W140" },
                    { 2100, "F18L2S119" },
                    { 2100, "F18L1W033" },
                    { 2100, "F18L1W011" },
                    { 2100, "F18L2S099" },
                    { 2101, "F18L2W067" },
                    { 2102, "F18L2S030" },
                    { 2103, "F18L2W006" },
                    { 2103, "F18L1W031" },
                    { 2103, "F18L2S030" },
                    { 2103, "F18L2W001" },
                    { 2103, "F18L1W033" },
                    { 2103, "F18L1S023" },
                    { 2102, "F18L2W046" },
                    { 2079, "F18L2W140" },
                    { 2100, "F18L1W005" },
                    { 2099, "F18L2S002" },
                    { 2092, "F18L2S100" },
                    { 2092, "F18L1W020" },
                    { 2092, "F18L2S124" },
                    { 2092, "F18L1S003" },
                    { 2093, "F18L2W006" },
                    { 2093, "F18L2S082" },
                    { 2093, "F18L2S119" },
                    { 2099, "F18L2W046" },
                    { 2094, "F18L2S097" },
                    { 2095, "F18L2S029" },
                    { 2096, "F18L2S100" },
                    { 2096, "F18L2S119" },
                    { 2096, "F18L2S082" },
                    { 2096, "F18L2W104" },
                    { 2097, "F18L2S017" },
                    { 2098, "F18L2S017" },
                    { 2095, "F18L2S099" },
                    { 2054, "F18L1W031" },
                    { 2079, "F18L3S010" },
                    { 2078, "F18L1S032" },
                    { 2062, "F18L2S030" },
                    { 2062, "F18L2S110" },
                    { 2062, "F18L2S029" },
                    { 2063, "F18L2W104" },
                    { 2064, "F18L2W104" },
                    { 2065, "F18L2W001" },
                    { 2065, "F18L2S030" },
                    { 2066, "F18L2W167" },
                    { 2066, "F18L2W006" },
                    { 2066, "F18L2S017" },
                    { 2066, "F18L2W104" },
                    { 2067, "F18L2W109" },
                    { 2067, "F18L2S084" },
                    { 2067, "F18L2S017" },
                    { 2067, "F18L2S097" },
                    { 2062, "F18L3S010" },
                    { 2061, "F18L1S034" },
                    { 2061, "F18L2S084" },
                    { 2061, "F18L1W031" },
                    { 2054, "F18L1S032" },
                    { 2054, "F18L2S100" },
                    { 2055, "F18L2W046" },
                    { 2055, "F18L2S030" },
                    { 2055, "F18L2S029" },
                    { 2056, "F18L2W140" },
                    { 2057, "F18L2S100" },
                    { 2068, "F18L2S100" },
                    { 2057, "F18L2S099" },
                    { 2057, "F18L2S082" },
                    { 2058, "F18L2W104" },
                    { 2059, "F18L2W046" },
                    { 2060, "F18L2W067" },
                    { 2060, "F18L2S099" },
                    { 2061, "F18L2W104" },
                    { 2061, "F18L1S015" },
                    { 2057, "F18L2W067" },
                    { 2069, "F18L1S003" },
                    { 2069, "F18L2W167" },
                    { 2069, "F18L2S110" },
                    { 2076, "F18L2S002" },
                    { 2076, "F18L2S017" },
                    { 2076, "F18L1S032" },
                    { 2076, "F18L1S023" },
                    { 2076, "F18L3S010" },
                    { 2076, "F18L1S003" },
                    { 2077, "F18L2W104" },
                    { 2076, "F18L2W104" },
                    { 2077, "F18L2W109" },
                    { 2077, "F18L2S029" },
                    { 2078, "F18L1W011" },
                    { 2078, "F18L1W070" },
                    { 2078, "F18L1W020" },
                    { 2078, "F18L1S016" },
                    { 2078, "F18L2W167" },
                    { 2078, "F18L2S002" },
                    { 2077, "F18L2S084" },
                    { 2079, "F18L2S124" },
                    { 2076, "F18L1W031" },
                    { 2076, "F18L2S099" },
                    { 2069, "F18L2W140" },
                    { 2069, "F18L1S026" },
                    { 2070, "F18L2W001" },
                    { 2070, "F18L2S082" },
                    { 2070, "F18L2W140" },
                    { 2071, "F18L2S084" },
                    { 2072, "F18L3S010" },
                    { 2076, "F18L1W070" },
                    { 2073, "F18L2S099" },
                    { 2073, "F18L2W167" },
                    { 2073, "F18L2S097" },
                    { 2074, "F18L3S010" },
                    { 2075, "F18L2S002" },
                    { 2075, "F18L2S100" },
                    { 2075, "F18L2W001" },
                    { 2076, "F18L1S116" },
                    { 2073, "F18L2S119" },
                    { 2004, "F18L2W104" },
                    { 2208, "F18L2W140" },
                    { 2209, "F18L2W104" },
                    { 3100, "F18L3S025" },
                    { 3100, "F18L3W027" },
                    { 3101, "F18L3S122" },
                    { 3101, "F18L3W085" },
                    { 3101, "F18L3W064" },
                    { 3102, "F18L2W104" },
                    { 3102, "F18L3S157" },
                    { 3102, "F18L3W043" },
                    { 3102, "F18L3S019" },
                    { 3102, "F18L3S059" },
                    { 3102, "F18L1W020" },
                    { 3102, "F18L3S118" },
                    { 3103, "F18L3S063" },
                    { 3103, "F18L3S135" },
                    { 3103, "F18L3W035" },
                    { 3099, "F18L3W024" },
                    { 3098, "F18L3S157" },
                    { 3097, "F18L3W050" },
                    { 3096, "F18L3W043" },
                    { 3091, "F18L3W085" },
                    { 3092, "F18L3S025" },
                    { 3093, "F18L3S166" },
                    { 3093, "F18L3S138" },
                    { 3093, "F18L3W043" },
                    { 3093, "F18L3W064" },
                    { 3093, "F18L3S141" },
                    { 3104, "F18L3W134" },
                    { 3093, "F18L1S045" },
                    { 3093, "F18L3S157" },
                    { 3094, "F18L3W024" },
                    { 3095, "F18L3W044" },
                    { 3095, "F18L3W136" },
                    { 3095, "F18L3S094" },
                    { 3096, "F18L3W134" },
                    { 3096, "F18L3S091" },
                    { 3093, "F18L1W005" },
                    { 3090, "F18L3S059" },
                    { 3104, "F18L3W064" },
                    { 3105, "F18L3S040" },
                    { 3113, "F18L3S036" },
                    { 3113, "F18L3W064" },
                    { 3113, "F18L3S122" },
                    { 3114, "F18L3W134" },
                    { 3114, "F18L3S091" },
                    { 3114, "F18L3S036" },
                    { 3114, "F18L3S019" },
                    { 3115, "F18L3S025" },
                    { 3116, "F18L3W085" },
                    { 3116, "F18L3W004" },
                    { 3116, "F18L3S157" },
                    { 3116, "F18L3S019" },
                    { 3117, "F18L3S063" },
                    { 3117, "F18L3S138" },
                    { 3117, "F18L3W050" },
                    { 3112, "F18L3W085" },
                    { 3112, "F18L3S025" },
                    { 3111, "F18L3S036" },
                    { 3111, "F18L3S122" },
                    { 3106, "F18L3W024" },
                    { 3107, "F18L3S138" },
                    { 3107, "F18L3W064" },
                    { 3107, "F18L3S157" },
                    { 3107, "F18L3W009" },
                    { 3108, "F18L3W064" },
                    { 3109, "F18L3S141" },
                    { 3104, "F18L3S138" },
                    { 3109, "F18L3W004" },
                    { 3109, "F18L3S059" },
                    { 3110, "F18L3W035" },
                    { 3110, "F18L3S063" },
                    { 3110, "F18L3S036" },
                    { 3110, "F18L3W085" },
                    { 3111, "F18L3S094" },
                    { 3111, "F18L3S091" },
                    { 3109, "F18L3W024" },
                    { 3090, "F18L3W136" },
                    { 3090, "F18L3W085" },
                    { 3090, "F18L3S025" },
                    { 3067, "F18L3S019" },
                    { 3067, "F18L3W043" },
                    { 3067, "F18L3S063" },
                    { 3068, "F18L3S059" },
                    { 3069, "F18L3S063" },
                    { 3069, "F18L3W008" },
                    { 3070, "F18L3S059" },
                    { 3070, "F18L3W134" },
                    { 3071, "F18L3S141" },
                    { 3072, "F18L3W043" },
                    { 3073, "F18L3S091" },
                    { 3073, "F18L3S036" },
                    { 3073, "F18L3W085" },
                    { 3074, "F18L3W064" },
                    { 3074, "F18L3S019" },
                    { 3066, "F18L3W009" },
                    { 3066, "F18L3S094" },
                    { 3066, "F18L3S141" },
                    { 3065, "F18L3S118" },
                    { 3062, "F18L3S025" },
                    { 3062, "F18L3W064" },
                    { 3063, "F18L3S010" },
                    { 3063, "F18L1S034" },
                    { 3063, "F18L2S124" },
                    { 3063, "F18L3W064" },
                    { 3063, "F18L2W167" },
                    { 3074, "F18L3W043" },
                    { 3063, "F18L3S130" },
                    { 3063, "F18L3S135" },
                    { 3064, "F18L3S025" },
                    { 3064, "F18L3S122" },
                    { 3064, "F18L3S040" },
                    { 3065, "F18L3W136" },
                    { 3065, "F18L3S063" },
                    { 3065, "F18L3W035" },
                    { 3063, "F18L1W007" },
                    { 3075, "F18L3W004" },
                    { 3075, "F18L3W136" },
                    { 3075, "F18L3S141" },
                    { 3083, "F18L3W043" },
                    { 3083, "F18L3W004" },
                    { 3084, "F18L3W035" },
                    { 3084, "F18L3W008" },
                    { 3084, "F18L3S040" },
                    { 3085, "F18L3S166" },
                    { 3085, "F18L3W050" },
                    { 3083, "F18L3W050" },
                    { 3086, "F18L3S094" },
                    { 3086, "F18L3S166" },
                    { 3086, "F18L3W004" },
                    { 3087, "F18L3W085" },
                    { 3088, "F18L3W060" },
                    { 3088, "F18L3W009" },
                    { 3088, "F18L3S130" },
                    { 3089, "F18L3S130" },
                    { 3086, "F18L3S118" },
                    { 3117, "F18L3W134" },
                    { 3083, "F18L3S166" },
                    { 3082, "F18L3W044" },
                    { 3075, "F18L3S019" },
                    { 3076, "F18L3S122" },
                    { 3076, "F18L3W044" },
                    { 3076, "F18L3W043" },
                    { 3077, "F18L3W085" },
                    { 3077, "F18L3W050" },
                    { 3077, "F18L3S157" },
                    { 3082, "F18L3W050" },
                    { 3077, "F18L3W043" },
                    { 3079, "F18L3S019" },
                    { 3080, "F18L3W050" },
                    { 3080, "F18L3W064" },
                    { 3080, "F18L3S138" },
                    { 3080, "F18L3W136" },
                    { 3081, "F18L3S118" },
                    { 3082, "F18L3S118" },
                    { 3078, "F18L3W004" },
                    { 3118, "F18L3W044" },
                    { 3119, "F18L3S141" },
                    { 3119, "F18L3W024" },
                    { 4031, "F18L2S099" },
                    { 4031, "F18L3W085" },
                    { 4031, "F18L2W109" },
                    { 4031, "F18L1S045" },
                    { 4031, "F18L3W136" },
                    { 4031, "F18L3S028" },
                    { 4031, "F18L1S013" },
                    { 4031, "F18L3S141" },
                    { 4032, "F18L3W126" },
                    { 4032, "F18L3S028" },
                    { 4032, "F18L3W129" },
                    { 4032, "F18L3W137" },
                    { 4033, "F18L3W129" },
                    { 4034, "F18L3W060" },
                    { 4034, "F18L3S155" },
                    { 4031, "F18L1S116" },
                    { 4031, "F18L3S107" },
                    { 4031, "F18L2W001" },
                    { 4030, "F18L3S028" },
                    { 4023, "F18L3W079" },
                    { 4024, "F18L3S086" },
                    { 4025, "F18L3S107" },
                    { 4025, "F18L3W137" },
                    { 4025, "F18L3W126" },
                    { 4025, "F18L3W060" },
                    { 4026, "F18L3W103" },
                    { 4035, "F18L3S107" },
                    { 4027, "F18L3W129" },
                    { 4028, "F18L3S028" },
                    { 4028, "F18L3W129" },
                    { 4028, "F18L3W037" },
                    { 4029, "F18L3W060" },
                    { 4029, "F18L3S107" },
                    { 4030, "F18L3S107" },
                    { 4030, "F18L3S077" },
                    { 4028, "F18L3S022" },
                    { 4036, "F18L3W060" },
                    { 4037, "F18L3S028" },
                    { 4037, "F18L3W079" },
                    { 4044, "F18L3W126" },
                    { 4044, "F18L3S086" },
                    { 4044, "F18L3S155" },
                    { 4045, "F18L3W103" },
                    { 4045, "F18L3S107" },
                    { 4045, "F18L3S028" },
                    { 4045, "F18L3W105" },
                    { 4043, "F18L3S022" },
                    { 4046, "F18L3W105" },
                    { 4046, "F18L3S077" },
                    { 4047, "F18L3W060" },
                    { 4048, "F18L3W126" },
                    { 4048, "F18L3S107" },
                    { 4048, "F18L3S022" },
                    { 4049, "F18L3S086" },
                    { 4049, "F18L3S022" },
                    { 4046, "F18L3W079" },
                    { 4023, "F18L3S077" },
                    { 4043, "F18L3S155" },
                    { 4043, "F18L3W126" },
                    { 4037, "F18L3S155" },
                    { 4038, "F18L3S086" },
                    { 4038, "F18L3W103" },
                    { 4038, "F18L3W079" },
                    { 4038, "F18L3W075" },
                    { 4039, "F18L3S086" },
                    { 4039, "F18L3W137" },
                    { 4043, "F18L3W129" },
                    { 4039, "F18L3W103" },
                    { 4040, "F18L3S028" },
                    { 4041, "F18L3W129" },
                    { 4041, "F18L3W126" },
                    { 4041, "F18L3W103" },
                    { 4041, "F18L3S107" },
                    { 4042, "F18L3S028" },
                    { 4042, "F18L3S022" },
                    { 4039, "F18L3W105" },
                    { 3061, "F18L3S118" },
                    { 4023, "F18L3S107" },
                    { 4022, "F18L3W129" },
                    { 4001, "F18L3W105" },
                    { 4002, "F18L2S124" },
                    { 4002, "F18L3W105" },
                    { 4002, "F18L1S120" },
                    { 4002, "F18L3W008" },
                    { 4002, "F18L1W070" },
                    { 4002, "F18L3W136" },
                    { 4002, "F18L1S013" },
                    { 4002, "F18L1S116" },
                    { 4002, "F18L1W005" },
                    { 4002, "F18L1S032" },
                    { 4003, "F18L3S028" },
                    { 4004, "F18L3W060" },
                    { 4004, "F18L3W075" },
                    { 4004, "F18L3W079" },
                    { 4001, "F18L3S077" },
                    { 4000, "F18L3W126" },
                    { 4000, "F18L3S155" },
                    { 4000, "F18L3W079" },
                    { 3119, "F18L3W004" },
                    { 3120, "F18L3S063" },
                    { 3120, "F18L3W085" },
                    { 3120, "F18L3S059" },
                    { 3120, "F18L3S094" },
                    { 3121, "F18L3W008" },
                    { 3121, "F18L3S019" },
                    { 4005, "F18L3W037" },
                    { 3122, "F18L3W134" },
                    { 3122, "F18L3S094" },
                    { 3122, "F18L3W044" },
                    { 3123, "F18L3W050" },
                    { 3123, "F18L3W044" },
                    { 3124, "F18L3S025" },
                    { 3124, "F18L3W044" },
                    { 3124, "F18L3S091" },
                    { 3122, "F18L3W004" },
                    { 4005, "F18L3W126" },
                    { 4006, "F18L3W079" },
                    { 4007, "F18L3W075" },
                    { 4015, "F18L3W037" },
                    { 4016, "F18L3S022" },
                    { 4016, "F18L3W129" },
                    { 4017, "F18L3W037" },
                    { 4017, "F18L3W126" },
                    { 4018, "F18L3W137" },
                    { 4018, "F18L3W079" },
                    { 4014, "F18L3W037" },
                    { 4019, "F18L3W079" },
                    { 4020, "F18L3W075" },
                    { 4020, "F18L3W037" },
                    { 4020, "F18L3S107" },
                    { 4021, "F18L3S107" },
                    { 4021, "F18L3W037" },
                    { 4022, "F18L3S086" },
                    { 4022, "F18L3W126" },
                    { 4019, "F18L3S028" },
                    { 4023, "F18L3W105" },
                    { 4014, "F18L3W075" },
                    { 4014, "F18L3S155" },
                    { 4007, "F18L3W129" },
                    { 4008, "F18L3W126" },
                    { 4008, "F18L3W079" },
                    { 4008, "F18L3S086" },
                    { 4009, "F18L3W060" },
                    { 4009, "F18L3S107" },
                    { 4010, "F18L3S107" },
                    { 4014, "F18L3W126" },
                    { 4010, "F18L3S028" },
                    { 4011, "F18L3S022" },
                    { 4012, "F18L3S107" },
                    { 4012, "F18L3W126" },
                    { 4012, "F18L3W105" },
                    { 4012, "F18L3W075" },
                    { 4013, "F18L3S028" },
                    { 4013, "F18L3W103" },
                    { 4010, "F18L3W075" },
                    { 3061, "F18L3W027" },
                    { 3060, "F18L3W004" },
                    { 3060, "F18L3S036" },
                    { 2236, "F18L2S119" },
                    { 2236, "F18L2S082" },
                    { 2237, "F18L2S082" },
                    { 2238, "F18L2S110" },
                    { 2238, "F18L2S002" },
                    { 2238, "F18L1S052" },
                    { 2238, "F18L1S032" },
                    { 2238, "F18L2W167" },
                    { 2238, "F18L2W109" },
                    { 2238, "F18L2W001" },
                    { 2239, "F18L2S030" },
                    { 2239, "F18L2W006" },
                    { 2239, "F18L2S124" },
                    { 2240, "F18L2S029" },
                    { 2240, "F18L2W067" },
                    { 2236, "F18L2S030" },
                    { 2235, "F18L2W046" },
                    { 2235, "F18L2S030" },
                    { 2235, "F18L2W006" },
                    { 2233, "F18L1W033" },
                    { 2233, "F18L2S099" },
                    { 2233, "F18L2S100" },
                    { 2233, "F18L2S030" },
                    { 2234, "F18L2S002" },
                    { 2234, "F18L2S029" },
                    { 2234, "F18L1W011" },
                    { 2240, "F18L2S110" },
                    { 2234, "F18L2S110" },
                    { 2234, "F18L1S003" },
                    { 2234, "F18L1S120" },
                    { 2234, "F18L1W005" },
                    { 2234, "F18L1S034" },
                    { 2234, "F18L2W001" },
                    { 2234, "F18L2S082" },
                    { 2235, "F18L2S097" },
                    { 2234, "F18L2S084" },
                    { 2241, "F18L2S029" },
                    { 2241, "F18L2S119" },
                    { 2241, "F18L2S084" },
                    { 2248, "F18L2S029" },
                    { 2248, "F18L2S030" },
                    { 2249, "F18L2S100" },
                    { 3000, "F18L3S094" },
                    { 3000, "F18L3S036" },
                    { 3000, "F18L3W050" },
                    { 3000, "F18L3S040" },
                    { 2248, "F18L2W001" },
                    { 3001, "F18L3W050" },
                    { 3001, "F18L3S019" },
                    { 3002, "F18L3S091" },
                    { 3003, "F18L3S091" },
                    { 3003, "F18L3W035" },
                    { 3003, "F18L3W064" }
                });

            migrationBuilder.InsertData(
                table: "StudentiPolagaatPredmeti",
                columns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                values: new object[,]
                {
                    { 3003, "F18L3S118" },
                    { 3004, "F18L3S122" },
                    { 3001, "F18L3S141" },
                    { 2233, "F18L1W020" },
                    { 2247, "F18L2W167" },
                    { 2247, "F18L1S116" },
                    { 2241, "F18L2W006" },
                    { 2242, "F18L2W104" },
                    { 2243, "F18L3S010" },
                    { 2243, "F18L2S099" },
                    { 2244, "F18L2W067" },
                    { 2244, "F18L2W109" },
                    { 2245, "F18L2S110" },
                    { 2247, "F18L2W067" },
                    { 2246, "F18L2S029" },
                    { 2247, "F18L2W109" },
                    { 2247, "F18L2S110" },
                    { 2247, "F18L1S034" },
                    { 2247, "F18L2W140" },
                    { 2247, "F18L2S124" },
                    { 2247, "F18L1W031" },
                    { 2247, "F18L2S084" },
                    { 2246, "F18L2S017" },
                    { 3004, "F18L3W060" },
                    { 2233, "F18L1S026" },
                    { 2233, "F18L1S120" },
                    { 2215, "F18L2S099" },
                    { 2216, "F18L2W001" },
                    { 2216, "F18L2W067" },
                    { 2216, "F18L2W140" },
                    { 2216, "F18L2S110" },
                    { 2217, "F18L2W006" },
                    { 2217, "F18L2W167" },
                    { 2217, "F18L2S082" },
                    { 2217, "F18L2S099" },
                    { 2218, "F18L2S100" },
                    { 2218, "F18L2W109" },
                    { 2218, "F18L3S010" },
                    { 2219, "F18L2S097" },
                    { 2219, "F18L2S082" },
                    { 2219, "F18L2W167" },
                    { 2215, "F18L2S030" },
                    { 2215, "F18L2W167" },
                    { 2214, "F18L2W109" },
                    { 2213, "F18L2W140" },
                    { 2210, "F18L2S110" },
                    { 2210, "F18L2S084" },
                    { 2210, "F18L2S097" },
                    { 2210, "F18L2S124" },
                    { 2211, "F18L2W104" },
                    { 2211, "F18L1W005" },
                    { 2211, "F18L1S146" },
                    { 2220, "F18L2S017" },
                    { 2211, "F18L2S110" },
                    { 2211, "F18L2S119" },
                    { 2211, "F18L2W167" },
                    { 2211, "F18L2S097" },
                    { 2212, "F18L2W104" },
                    { 2213, "F18L2S100" },
                    { 2213, "F18L2W067" },
                    { 2213, "F18L2S110" },
                    { 2211, "F18L2S029" },
                    { 2220, "F18L2S099" },
                    { 2220, "F18L2W167" },
                    { 2221, "F18L1W020" },
                    { 2227, "F18L2S124" },
                    { 2228, "F18L2S100" },
                    { 2228, "F18L1S120" },
                    { 2228, "F18L2S099" },
                    { 2228, "F18L1W007" },
                    { 2228, "F18L1S034" },
                    { 2229, "F18L3S010" },
                    { 2226, "F18L2S099" },
                    { 2230, "F18L2S100" },
                    { 2231, "F18L2S100" },
                    { 2231, "F18L2S110" },
                    { 2231, "F18L2W167" },
                    { 2232, "F18L2S110" },
                    { 2233, "F18L1S015" },
                    { 2233, "F18L2S084" },
                    { 2233, "F18L2S119" },
                    { 2230, "F18L2S017" },
                    { 2233, "F18L1W049" },
                    { 2225, "F18L2W001" },
                    { 2224, "F18L2W006" },
                    { 2221, "F18L1S032" },
                    { 2221, "F18L3S010" },
                    { 2221, "F18L2W006" },
                    { 2221, "F18L2S084" },
                    { 2221, "F18L1S013" },
                    { 2221, "F18L1W007" },
                    { 2221, "F18L2W104" },
                    { 2224, "F18L2W067" },
                    { 2221, "F18L2W167" },
                    { 2222, "F18L2S099" },
                    { 2222, "F18L2S017" },
                    { 2222, "F18L2S124" },
                    { 2222, "F18L2S097" },
                    { 2223, "F18L3S010" },
                    { 2223, "F18L2S030" },
                    { 2224, "F18L2S099" },
                    { 2221, "F18L1S045" },
                    { 2208, "F18L2S100" },
                    { 3004, "F18L3W134" },
                    { 3005, "F18L3S063" },
                    { 3043, "F18L3W004" },
                    { 3043, "F18L3S063" },
                    { 3043, "F18L3W024" },
                    { 3044, "F18L3S135" },
                    { 3044, "F18L3S036" },
                    { 3044, "F18L3W043" },
                    { 3044, "F18L3S166" },
                    { 3045, "F18L3W027" },
                    { 3045, "F18L3W134" },
                    { 3045, "F18L3S118" },
                    { 3045, "F18L1W007" },
                    { 3045, "F18L2S100" },
                    { 3045, "F18L2S110" },
                    { 3045, "F18L3S141" },
                    { 3045, "F18L1S045" },
                    { 3042, "F18L3S122" },
                    { 3042, "F18L3W085" },
                    { 3041, "F18L3S141" },
                    { 3041, "F18L3S130" },
                    { 3037, "F18L3W085" },
                    { 3038, "F18L3W085" },
                    { 3039, "F18L2S100" },
                    { 3039, "F18L3S135" },
                    { 3039, "F18L2W046" },
                    { 3039, "F18L3W044" },
                    { 3039, "F18L1W041" },
                    { 3045, "F18L1S034" },
                    { 3039, "F18L3W134" },
                    { 3039, "F18L2S017" },
                    { 3039, "F18L1S034" },
                    { 3040, "F18L3S135" },
                    { 3040, "F18L3S091" },
                    { 3040, "F18L3S036" },
                    { 3041, "F18L3W035" },
                    { 3041, "F18L3S157" },
                    { 3039, "F18L2S002" },
                    { 3045, "F18L3W136" },
                    { 3046, "F18L3W050" },
                    { 3046, "F18L3W004" },
                    { 3054, "F18L3S025" },
                    { 3054, "F18L3S036" },
                    { 3054, "F18L3W064" },
                    { 3055, "F18L3W064" },
                    { 3056, "F18L3W004" },
                    { 3056, "F18L3S118" },
                    { 3056, "F18L3W064" },
                    { 3053, "F18L3W035" },
                    { 3057, "F18L3S157" },
                    { 3058, "F18L3S130" },
                    { 3058, "F18L3W027" },
                    { 3059, "F18L3S040" },
                    { 3059, "F18L3W085" },
                    { 3059, "F18L3S019" },
                    { 3059, "F18L3S094" },
                    { 3060, "F18L3S091" },
                    { 3058, "F18L3S059" },
                    { 3037, "F18L3S025" },
                    { 3053, "F18L3S063" },
                    { 3052, "F18L3W035" },
                    { 3047, "F18L3W008" },
                    { 3047, "F18L3W085" },
                    { 3047, "F18L3W134" },
                    { 3047, "F18L3S135" },
                    { 3048, "F18L3S063" },
                    { 3048, "F18L3W043" },
                    { 3048, "F18L3S091" },
                    { 3052, "F18L3S019" },
                    { 3049, "F18L3W050" },
                    { 3050, "F18L3S122" },
                    { 3050, "F18L3W043" },
                    { 3050, "F18L3S157" },
                    { 3051, "F18L3W043" },
                    { 3051, "F18L3W004" },
                    { 3052, "F18L3W060" },
                    { 3052, "F18L3W043" },
                    { 3050, "F18L3S040" },
                    { 3004, "F18L3W136" },
                    { 3037, "F18L3S036" },
                    { 3036, "F18L3W136" },
                    { 3013, "F18L3W004" },
                    { 3014, "F18L3W085" },
                    { 3015, "F18L3S157" },
                    { 3016, "F18L3W134" },
                    { 3016, "F18L3W043" },
                    { 3017, "F18L3S019" },
                    { 3017, "F18L3W027" },
                    { 3017, "F18L3W009" },
                    { 3017, "F18L3W008" },
                    { 3018, "F18L3W024" },
                    { 3018, "F18L3W004" },
                    { 3019, "F18L3W004" },
                    { 3020, "F18L3S130" },
                    { 3020, "F18L3S122" },
                    { 3021, "F18L3S091" },
                    { 3012, "F18L3W008" },
                    { 3011, "F18L3S063" },
                    { 3011, "F18L3W024" },
                    { 3011, "F18L3W044" },
                    { 3005, "F18L3W008" },
                    { 3005, "F18L3W085" },
                    { 3006, "F18L3S059" },
                    { 3006, "F18L3W060" },
                    { 3006, "F18L3S135" },
                    { 3006, "F18L3W004" },
                    { 3007, "F18L3S025" },
                    { 3021, "F18L3S122" },
                    { 3008, "F18L3W009" },
                    { 3009, "F18L3W004" },
                    { 3009, "F18L3W043" },
                    { 3009, "F18L3S138" },
                    { 3009, "F18L3W044" },
                    { 3010, "F18L3S059" },
                    { 3010, "F18L3W004" },
                    { 3010, "F18L3W136" },
                    { 3008, "F18L3S118" },
                    { 3022, "F18L3W136" },
                    { 3022, "F18L3S130" },
                    { 3023, "F18L3S122" },
                    { 3029, "F18L3W009" },
                    { 3030, "F18L3W064" },
                    { 3030, "F18L3W134" },
                    { 3030, "F18L3S063" },
                    { 3030, "F18L3W027" },
                    { 3031, "F18L3S094" },
                    { 3032, "F18L3S138" },
                    { 3029, "F18L3S040" },
                    { 3032, "F18L3W009" },
                    { 3032, "F18L3W060" },
                    { 3033, "F18L3W024" },
                    { 3034, "F18L3W134" },
                    { 3034, "F18L3W050" },
                    { 3034, "F18L3W024" },
                    { 3034, "F18L3S094" },
                    { 3035, "F18L3S040" },
                    { 3032, "F18L3S094" },
                    { 3036, "F18L3W027" },
                    { 3028, "F18L3S094" },
                    { 3028, "F18L3W085" },
                    { 3023, "F18L3W134" },
                    { 3024, "F18L3S157" },
                    { 3025, "F18L3S040" },
                    { 3025, "F18L3S122" },
                    { 3025, "F18L3W136" },
                    { 3025, "F18L3S157" },
                    { 3025, "F18L2W001" },
                    { 3028, "F18L3W044" },
                    { 3025, "F18L3W044" },
                    { 3026, "F18L3W035" },
                    { 3026, "F18L3S019" },
                    { 3026, "F18L3S157" },
                    { 3026, "F18L3W008" },
                    { 3027, "F18L3W060" },
                    { 3027, "F18L3S118" },
                    { 3027, "F18L3S130" },
                    { 3025, "F18L1S015" },
                    { 4049, "F18L3W105" },
                    { 2004, "F18L2W167" },
                    { 2002, "F18L1W070" },
                    { 1169, "F18L1W033" },
                    { 1169, "F18L1W070" },
                    { 1169, "F18L1W041" },
                    { 1170, "F18L1S120" },
                    { 1170, "F18L1W070" },
                    { 1170, "F18L1W020" },
                    { 1170, "F18L1S034" },
                    { 1171, "F18L1S013" },
                    { 1171, "F18L1W033" },
                    { 1172, "F18L1S034" },
                    { 1172, "F18L1S116" },
                    { 1173, "F18L1S015" },
                    { 1174, "F18L1W031" },
                    { 1174, "F18L1W041" },
                    { 1174, "F18L1W049" },
                    { 1169, "F18L1S034" },
                    { 1168, "F18L1S032" },
                    { 1168, "F18L1S013" },
                    { 1167, "F18L1S116" },
                    { 1161, "F18L1W020" },
                    { 1162, "F18L1S015" },
                    { 1163, "F18L1W007" },
                    { 1163, "F18L1S146" },
                    { 1163, "F18L1W049" },
                    { 1163, "F18L1W070" },
                    { 1164, "F18L1W031" },
                    { 1174, "F18L1S013" },
                    { 1164, "F18L1S013" },
                    { 1165, "F18L1S146" },
                    { 1165, "F18L1S013" },
                    { 1166, "F18L1S120" },
                    { 1166, "F18L1S045" },
                    { 1166, "F18L1W031" },
                    { 1166, "F18L1S013" },
                    { 1167, "F18L1S023" },
                    { 1165, "F18L1W049" },
                    { 1160, "F18L1W031" },
                    { 1175, "F18L1S026" },
                    { 1176, "F18L1W031" },
                    { 1183, "F18L1W007" },
                    { 1183, "F18L1W049" },
                    { 1183, "F18L1S120" },
                    { 1184, "F18L1S045" },
                    { 1184, "F18L1W007" },
                    { 1185, "F18L1W041" },
                    { 1186, "F18L1S016" },
                    { 1186, "F18L1S052" },
                    { 1186, "F18L1S013" },
                    { 1187, "F18L1W020" },
                    { 1187, "F18L1S146" },
                    { 1188, "F18L1S015" },
                    { 1188, "F18L1W020" },
                    { 1188, "F18L1S045" },
                    { 1189, "F18L1W033" },
                    { 1182, "F18L1W041" },
                    { 1181, "F18L1S016" },
                    { 1181, "F18L1S003" },
                    { 1181, "F18L1S034" },
                    { 1176, "F18L1S023" },
                    { 1176, "F18L1S016" },
                    { 1177, "F18L1S052" },
                    { 1177, "F18L1S034" },
                    { 1177, "F18L1W049" },
                    { 1177, "F18L1W007" },
                    { 1178, "F18L1S015" },
                    { 1176, "F18L1W070" },
                    { 1178, "F18L1S023" },
                    { 1179, "F18L1W007" },
                    { 1179, "F18L1W049" },
                    { 1179, "F18L1W070" },
                    { 1179, "F18L1S023" },
                    { 1180, "F18L1W005" },
                    { 1180, "F18L1S016" },
                    { 1180, "F18L1W011" },
                    { 1178, "F18L1W011" },
                    { 1159, "F18L1S023" },
                    { 1159, "F18L1W011" },
                    { 1159, "F18L1W033" },
                    { 1137, "F18L1S003" },
                    { 1137, "F18L1S015" },
                    { 1137, "F18L1S034" },
                    { 1138, "F18L1S052" },
                    { 1139, "F18L1S052" },
                    { 1140, "F18L1S026" },
                    { 1141, "F18L1S026" },
                    { 1141, "F18L1W031" },
                    { 1141, "F18L1S120" },
                    { 1141, "F18L1S116" },
                    { 1142, "F18L1W005" },
                    { 1142, "F18L1S034" },
                    { 1142, "F18L1W049" },
                    { 1143, "F18L1S146" },
                    { 1143, "F18L1W033" },
                    { 1136, "F18L1W005" },
                    { 1136, "F18L1S015" },
                    { 1136, "F18L1S052" },
                    { 1135, "F18L1W011" },
                    { 1128, "F18L1W041" },
                    { 1129, "F18L1S015" },
                    { 1129, "F18L1W049" },
                    { 1129, "F18L1S120" },
                    { 1129, "F18L1S026" },
                    { 1130, "F18L1S045" },
                    { 1130, "F18L1S116" },
                    { 1143, "F18L1S120" },
                    { 1130, "F18L1S032" },
                    { 1131, "F18L1W007" },
                    { 1132, "F18L1S120" },
                    { 1133, "F18L1W041" },
                    { 1134, "F18L1S003" },
                    { 1134, "F18L1W020" },
                    { 1135, "F18L1W049" },
                    { 1135, "F18L1W041" },
                    { 1130, "F18L1S016" },
                    { 1143, "F18L1W041" },
                    { 1144, "F18L1W031" },
                    { 1145, "F18L1S052" },
                    { 1152, "F18L1S026" },
                    { 1152, "F18L1S146" },
                    { 1152, "F18L1S032" },
                    { 1153, "F18L1S013" },
                    { 1153, "F18L1S052" },
                    { 1154, "F18L1S003" },
                    { 1155, "F18L1S146" },
                    { 1151, "F18L1W020" },
                    { 1155, "F18L1S120" },
                    { 1155, "F18L1S013" },
                    { 1156, "F18L1W070" },
                    { 1157, "F18L1W005" },
                    { 1157, "F18L1W007" },
                    { 1157, "F18L1W070" },
                    { 1157, "F18L1W041" },
                    { 1158, "F18L1W020" },
                    { 1155, "F18L1S116" },
                    { 1190, "F18L1W070" },
                    { 1151, "F18L1W049" },
                    { 1150, "F18L1S034" },
                    { 1145, "F18L1S034" },
                    { 1145, "F18L1S013" },
                    { 1145, "F18L1W011" },
                    { 1146, "F18L1W041" },
                    { 1147, "F18L1S052" },
                    { 1147, "F18L1S015" },
                    { 1147, "F18L1S026" },
                    { 1151, "F18L1S026" },
                    { 1147, "F18L1W020" },
                    { 1148, "F18L1S045" },
                    { 1148, "F18L1S003" },
                    { 1148, "F18L1S034" },
                    { 1149, "F18L1S052" },
                    { 1149, "F18L1S023" },
                    { 1149, "F18L1W020" },
                    { 1149, "F18L1S013" },
                    { 1148, "F18L1S146" },
                    { 1191, "F18L1S146" },
                    { 1191, "F18L1S016" },
                    { 1191, "F18L1W041" },
                    { 1231, "F18L1W020" },
                    { 1231, "F18L1S052" },
                    { 1232, "F18L1W005" },
                    { 1232, "F18L1S023" },
                    { 1232, "F18L1S016" },
                    { 1233, "F18L1S016" },
                    { 1233, "F18L1S116" },
                    { 1233, "F18L1W033" },
                    { 1233, "F18L1S032" },
                    { 1234, "F18L1S016" },
                    { 1235, "F18L1W070" },
                    { 1235, "F18L1S120" },
                    { 1235, "F18L1S023" },
                    { 1236, "F18L1S034" },
                    { 1237, "F18L1W011" },
                    { 1231, "F18L1W005" },
                    { 1231, "F18L1S146" },
                    { 1230, "F18L1S034" },
                    { 1230, "F18L1W005" },
                    { 1223, "F18L1W041" },
                    { 1224, "F18L1W033" },
                    { 1224, "F18L1S003" },
                    { 1224, "F18L1S146" },
                    { 1224, "F18L1W005" },
                    { 1225, "F18L1S023" },
                    { 1225, "F18L1S052" },
                    { 1237, "F18L1S015" },
                    { 1226, "F18L1W011" },
                    { 1227, "F18L1S003" },
                    { 1228, "F18L1W020" },
                    { 1228, "F18L1W041" },
                    { 1229, "F18L1W033" },
                    { 1229, "F18L1S120" },
                    { 1230, "F18L1S015" },
                    { 1230, "F18L1S045" },
                    { 1226, "F18L1S052" },
                    { 1237, "F18L1W007" },
                    { 1238, "F18L1W049" },
                    { 1238, "F18L1W007" },
                    { 1246, "F18L1S120" },
                    { 1246, "F18L1W020" },
                    { 1246, "F18L1S052" },
                    { 1246, "F18L1S034" },
                    { 1247, "F18L1S003" },
                    { 1248, "F18L1W007" },
                    { 1248, "F18L1S026" },
                    { 1245, "F18L1W011" },
                    { 1248, "F18L1W031" },
                    { 1249, "F18L1S052" },
                    { 1250, "F18L1S016" },
                    { 1250, "F18L1W031" },
                    { 1250, "F18L1S052" },
                    { 1250, "F18L1S003" },
                    { 1251, "F18L1W031" },
                    { 1251, "F18L1S034" },
                    { 1248, "F18L1W011" },
                    { 1223, "F18L1W020" },
                    { 1245, "F18L1S146" },
                    { 1244, "F18L1W005" },
                    { 1238, "F18L1S146" },
                    { 1239, "F18L1S146" },
                    { 1239, "F18L1S026" },
                    { 1240, "F18L1S120" },
                    { 1241, "F18L1S003" },
                    { 1241, "F18L1S032" },
                    { 1241, "F18L1S045" },
                    { 1244, "F18L1S116" },
                    { 1241, "F18L1S026" },
                    { 1242, "F18L1W020" },
                    { 1242, "F18L1S032" },
                    { 1243, "F18L1S052" },
                    { 1243, "F18L1S146" },
                    { 1243, "F18L1S032" },
                    { 1244, "F18L1W011" },
                    { 1244, "F18L1S026" },
                    { 1242, "F18L1S023" },
                    { 1128, "F18L1S116" },
                    { 1223, "F18L1S003" },
                    { 1222, "F18L1S023" },
                    { 1201, "F18L1W005" },
                    { 1201, "F18L1S016" },
                    { 1202, "F18L1S045" },
                    { 1202, "F18L1S034" },
                    { 1202, "F18L1W049" },
                    { 1203, "F18L1S003" },
                    { 1204, "F18L1S146" },
                    { 1205, "F18L1S116" },
                    { 1205, "F18L1S146" },
                    { 1206, "F18L1W011" },
                    { 1206, "F18L1S015" },
                    { 1206, "F18L1S146" },
                    { 1207, "F18L1S003" },
                    { 1208, "F18L1S146" },
                    { 1208, "F18L1W005" },
                    { 1201, "F18L1W031" },
                    { 1201, "F18L1W070" },
                    { 1200, "F18L1W005" },
                    { 1199, "F18L1S015" },
                    { 1192, "F18L1S116" },
                    { 1192, "F18L1S015" },
                    { 1192, "F18L1S003" },
                    { 1193, "F18L1W007" },
                    { 1194, "F18L1S146" },
                    { 1195, "F18L1S032" },
                    { 1196, "F18L1W070" },
                    { 1208, "F18L1W049" },
                    { 1196, "F18L1W041" },
                    { 1197, "F18L1S045" },
                    { 1197, "F18L1W033" },
                    { 1197, "F18L1W049" },
                    { 1198, "F18L1S023" },
                    { 1199, "F18L1W070" },
                    { 1199, "F18L1S045" },
                    { 1199, "F18L1W031" },
                    { 1197, "F18L1S116" },
                    { 1209, "F18L1W005" },
                    { 1209, "F18L1S003" },
                    { 1209, "F18L1W070" },
                    { 1216, "F18L1S120" },
                    { 1216, "F18L1S146" },
                    { 1217, "F18L1W033" },
                    { 1218, "F18L1W033" },
                    { 1218, "F18L1S023" },
                    { 1218, "F18L1W041" },
                    { 1219, "F18L1S016" },
                    { 1216, "F18L1W007" },
                    { 1219, "F18L1S013" },
                    { 1220, "F18L1W033" },
                    { 1220, "F18L1S013" },
                    { 1221, "F18L1W007" },
                    { 1221, "F18L1W049" },
                    { 1221, "F18L1S015" },
                    { 1222, "F18L1S013" },
                    { 1222, "F18L1W033" },
                    { 1220, "F18L1W020" },
                    { 1223, "F18L1W033" },
                    { 1215, "F18L1S116" },
                    { 1215, "F18L1S015" },
                    { 1209, "F18L1S120" },
                    { 1210, "F18L1S003" },
                    { 1210, "F18L1S120" },
                    { 1210, "F18L1W007" },
                    { 1211, "F18L1S015" },
                    { 1211, "F18L1W005" },
                    { 1211, "F18L1S045" },
                    { 1215, "F18L1S146" },
                    { 1211, "F18L1S120" },
                    { 1212, "F18L1W041" },
                    { 1212, "F18L1S032" },
                    { 1212, "F18L1W011" },
                    { 1213, "F18L1W020" },
                    { 1214, "F18L1S032" },
                    { 1214, "F18L1S034" },
                    { 1215, "F18L1S032" },
                    { 1212, "F18L1S034" },
                    { 1128, "F18L1S003" },
                    { 1128, "F18L1W033" },
                    { 1127, "F18L1W070" },
                    { 1040, "F18L1W041" },
                    { 1040, "F18L1S120" },
                    { 1040, "F18L1S116" },
                    { 1040, "F18L1W049" },
                    { 1041, "F18L1W031" },
                    { 1042, "F18L1W020" },
                    { 1042, "F18L1S052" },
                    { 1043, "F18L1S023" },
                    { 1044, "F18L1W070" },
                    { 1044, "F18L1S015" },
                    { 1044, "F18L1S034" },
                    { 1044, "F18L1W020" },
                    { 1045, "F18L1W031" },
                    { 1045, "F18L1W007" },
                    { 1046, "F18L1S013" },
                    { 1039, "F18L1S003" },
                    { 1039, "F18L1S034" },
                    { 1039, "F18L1W007" },
                    { 1039, "F18L1S016" },
                    { 1032, "F18L1W020" },
                    { 1033, "F18L1S052" },
                    { 1033, "F18L1W070" },
                    { 1033, "F18L1W011" },
                    { 1034, "F18L1W049" },
                    { 1034, "F18L1S026" },
                    { 1034, "F18L1S015" },
                    { 1046, "F18L1S045" },
                    { 1035, "F18L1S034" },
                    { 1035, "F18L1W049" },
                    { 1036, "F18L1S023" },
                    { 1036, "F18L1S015" },
                    { 1036, "F18L1S013" },
                    { 1037, "F18L1W041" },
                    { 1038, "F18L1S045" },
                    { 1038, "F18L1S120" },
                    { 1035, "F18L1S026" },
                    { 1046, "F18L1S032" },
                    { 1047, "F18L1W049" },
                    { 1047, "F18L1W070" },
                    { 1055, "F18L1S023" },
                    { 1055, "F18L1W011" },
                    { 1055, "F18L1S034" },
                    { 1056, "F18L1S034" },
                    { 1056, "F18L1W033" },
                    { 1057, "F18L1S032" },
                    { 1058, "F18L1W049" },
                    { 1055, "F18L1S116" },
                    { 1058, "F18L1W005" },
                    { 1058, "F18L1S034" },
                    { 1059, "F18L1W049" },
                    { 1060, "F18L1S026" },
                    { 1061, "F18L1S026" },
                    { 1061, "F18L1S116" },
                    { 1061, "F18L1W033" },
                    { 1061, "F18L1W020" },
                    { 1058, "F18L1S032" },
                    { 1032, "F18L1W005" },
                    { 1054, "F18L1S003" },
                    { 1054, "F18L1S013" },
                    { 1047, "F18L1S023" },
                    { 1048, "F18L1S116" },
                    { 1048, "F18L1S146" },
                    { 1049, "F18L1W049" },
                    { 1049, "F18L1W033" },
                    { 1049, "F18L1W070" },
                    { 1049, "F18L1S032" },
                    { 1054, "F18L1S032" },
                    { 1050, "F18L1S146" },
                    { 1051, "F18L1W049" },
                    { 1052, "F18L1S026" },
                    { 1053, "F18L1S052" },
                    { 1053, "F18L1S045" },
                    { 1053, "F18L1W070" },
                    { 1053, "F18L1W031" },
                    { 1054, "F18L1W031" },
                    { 1050, "F18L1S003" },
                    { 1062, "F18L1W033" },
                    { 1032, "F18L1S032" },
                    { 1031, "F18L1W020" },
                    { 1008, "F18L1S146" },
                    { 1008, "F18L1W041" },
                    { 1008, "F18L1W005" },
                    { 1009, "F18L1S116" },
                    { 1010, "F18L1W070" },
                    { 1010, "F18L1W020" },
                    { 1010, "F18L1S034" },
                    { 1011, "F18L1W031" },
                    { 1011, "F18L1S034" },
                    { 1011, "F18L1W070" },
                    { 1011, "F18L1W007" },
                    { 1012, "F18L1S146" },
                    { 1012, "F18L1S013" },
                    { 1012, "F18L1W070" },
                    { 1013, "F18L1W070" },
                    { 1007, "F18L1S016" },
                    { 1007, "F18L1S120" },
                    { 1007, "F18L1S023" },
                    { 1007, "F18L1S034" },
                    { 1001, "F18L1W020" },
                    { 1001, "F18L1S045" },
                    { 1001, "F18L1S052" },
                    { 1002, "F18L1S015" },
                    { 1002, "F18L1W007" },
                    { 1002, "F18L1W031" },
                    { 1002, "F18L1S045" },
                    { 1013, "F18L1S146" },
                    { 1003, "F18L1W020" },
                    { 1004, "F18L1W070" },
                    { 1004, "F18L1W005" },
                    { 1005, "F18L1W070" },
                    { 1005, "F18L1S052" },
                    { 1006, "F18L1S120" },
                    { 1006, "F18L1S016" },
                    { 1006, "F18L1W041" },
                    { 1003, "F18L1S045" },
                    { 1013, "F18L1W049" },
                    { 1014, "F18L1S013" },
                    { 1014, "F18L1W041" },
                    { 1024, "F18L1W033" },
                    { 1025, "F18L1W033" },
                    { 1025, "F18L1W005" },
                    { 1026, "F18L1S045" },
                    { 1026, "F18L1S034" },
                    { 1027, "F18L1S052" },
                    { 1027, "F18L1W049" },
                    { 1024, "F18L1S045" },
                    { 1027, "F18L1S026" },
                    { 1028, "F18L1S015" },
                    { 1029, "F18L1W020" },
                    { 1029, "F18L1W031" },
                    { 1030, "F18L1W041" },
                    { 1030, "F18L1S003" },
                    { 1030, "F18L1S034" },
                    { 1031, "F18L1S146" },
                    { 1027, "F18L1W020" },
                    { 1032, "F18L1S013" },
                    { 1023, "F18L1S015" },
                    { 1023, "F18L1S013" },
                    { 1014, "F18L1S120" },
                    { 1015, "F18L1W020" },
                    { 1015, "F18L1S032" },
                    { 1016, "F18L1S034" },
                    { 1016, "F18L1S146" },
                    { 1016, "F18L1W041" },
                    { 1016, "F18L1S032" },
                    { 1023, "F18L1S120" },
                    { 1017, "F18L1S032" },
                    { 1017, "F18L1S146" },
                    { 1018, "F18L1S023" },
                    { 1019, "F18L1S015" },
                    { 1020, "F18L1S032" },
                    { 1021, "F18L1S016" },
                    { 1022, "F18L1W041" },
                    { 1022, "F18L1W011" },
                    { 1017, "F18L1S120" },
                    { 1251, "F18L1W033" },
                    { 1062, "F18L1W005" },
                    { 1062, "F18L1W011" },
                    { 1104, "F18L1W031" },
                    { 1104, "F18L1W041" },
                    { 1104, "F18L1S116" },
                    { 1104, "F18L1W011" },
                    { 1105, "F18L1S013" },
                    { 1105, "F18L1S032" },
                    { 1105, "F18L1S120" },
                    { 1106, "F18L1S116" },
                    { 1106, "F18L1S120" },
                    { 1107, "F18L1S016" },
                    { 1107, "F18L1W011" },
                    { 1107, "F18L1W049" },
                    { 1108, "F18L1W005" },
                    { 1108, "F18L1S026" },
                    { 1108, "F18L1S015" },
                    { 1103, "F18L1S026" },
                    { 1103, "F18L1S013" },
                    { 1103, "F18L1W033" },
                    { 1103, "F18L1S023" },
                    { 1096, "F18L1W005" },
                    { 1097, "F18L1S016" },
                    { 1098, "F18L1W011" },
                    { 1098, "F18L1W005" },
                    { 1098, "F18L1W041" },
                    { 1098, "F18L1S052" },
                    { 1099, "F18L1W005" },
                    { 1108, "F18L1S146" },
                    { 1099, "F18L1W020" },
                    { 1100, "F18L1W011" },
                    { 1101, "F18L1S026" },
                    { 1101, "F18L1S116" },
                    { 1101, "F18L1S015" },
                    { 1102, "F18L1S023" },
                    { 1102, "F18L1W041" },
                    { 1102, "F18L1S016" },
                    { 1100, "F18L1S120" },
                    { 1109, "F18L1S015" },
                    { 1109, "F18L1W031" },
                    { 1110, "F18L1W033" },
                    { 1119, "F18L1S034" },
                    { 1120, "F18L1W031" },
                    { 1120, "F18L1S015" },
                    { 1120, "F18L1S016" },
                    { 1121, "F18L1S026" },
                    { 1121, "F18L1W070" },
                    { 1121, "F18L1W049" },
                    { 1118, "F18L1W041" },
                    { 1121, "F18L1S146" },
                    { 1122, "F18L1W049" },
                    { 1123, "F18L1S003" },
                    { 1124, "F18L1S015" },
                    { 1125, "F18L1W007" },
                    { 1125, "F18L1S052" },
                    { 1126, "F18L1S052" },
                    { 1127, "F18L1W041" },
                    { 1122, "F18L1S034" },
                    { 1096, "F18L1S013" },
                    { 1117, "F18L1S023" },
                    { 1117, "F18L1S034" },
                    { 1111, "F18L1W020" },
                    { 1111, "F18L1S003" },
                    { 1112, "F18L1S026" },
                    { 1112, "F18L1S013" },
                    { 1113, "F18L1S052" },
                    { 1113, "F18L1S034" },
                    { 1113, "F18L1S003" },
                    { 1117, "F18L1W049" },
                    { 1113, "F18L1W020" },
                    { 1114, "F18L1W007" },
                    { 1115, "F18L1S013" },
                    { 1115, "F18L1W070" },
                    { 1115, "F18L1S003" },
                    { 1115, "F18L1W033" },
                    { 1116, "F18L1S052" },
                    { 1116, "F18L1W005" },
                    { 1114, "F18L1S116" },
                    { 1062, "F18L1S003" },
                    { 1096, "F18L1S045" },
                    { 1095, "F18L1S023" },
                    { 1075, "F18L1S003" },
                    { 1075, "F18L1S116" },
                    { 1075, "F18L1S023" },
                    { 1075, "F18L1S045" },
                    { 1076, "F18L1S045" },
                    { 1076, "F18L1S015" },
                    { 1077, "F18L1S013" },
                    { 1078, "F18L1W070" },
                    { 1078, "F18L1S045" },
                    { 1079, "F18L1W011" },
                    { 1079, "F18L1S120" },
                    { 1079, "F18L1W020" },
                    { 1080, "F18L1S003" },
                    { 1080, "F18L1S120" },
                    { 1081, "F18L1S120" },
                    { 1074, "F18L1S013" },
                    { 1073, "F18L1S015" },
                    { 1072, "F18L1W005" },
                    { 1071, "F18L1W007" },
                    { 1063, "F18L1W070" },
                    { 1064, "F18L1W007" },
                    { 1064, "F18L1W070" },
                    { 1065, "F18L1S016" },
                    { 1065, "F18L1W070" },
                    { 1066, "F18L1W011" },
                    { 1066, "F18L1W020" },
                    { 1081, "F18L1S013" },
                    { 1067, "F18L1W041" },
                    { 1068, "F18L1W070" },
                    { 1068, "F18L1W049" },
                    { 1069, "F18L1S013" },
                    { 1069, "F18L1W041" },
                    { 1069, "F18L1W031" },
                    { 1070, "F18L1S034" },
                    { 1070, "F18L1W033" },
                    { 1067, "F18L1S023" },
                    { 1081, "F18L1S146" },
                    { 1081, "F18L1S003" },
                    { 1082, "F18L1S032" },
                    { 1090, "F18L1W020" },
                    { 1091, "F18L1S003" },
                    { 1091, "F18L1S015" },
                    { 1091, "F18L1W033" },
                    { 1091, "F18L1S026" },
                    { 1092, "F18L1S146" },
                    { 1092, "F18L1W005" },
                    { 1090, "F18L1W031" },
                    { 1092, "F18L1S026" },
                    { 1093, "F18L1S032" },
                    { 1093, "F18L1S034" },
                    { 1093, "F18L1S016" },
                    { 1094, "F18L1S052" },
                    { 1094, "F18L1S146" },
                    { 1094, "F18L1W041" },
                    { 1094, "F18L1W020" },
                    { 1092, "F18L1S116" },
                    { 1096, "F18L1W033" },
                    { 1089, "F18L1S015" },
                    { 1088, "F18L1W033" },
                    { 1082, "F18L1W033" },
                    { 1083, "F18L1W049" },
                    { 1083, "F18L1S013" },
                    { 1083, "F18L1S052" },
                    { 1083, "F18L1S034" },
                    { 1084, "F18L1W005" },
                    { 1084, "F18L1W041" },
                    { 1089, "F18L1S023" },
                    { 1084, "F18L1W070" },
                    { 1085, "F18L1S052" },
                    { 1085, "F18L1W007" },
                    { 1085, "F18L1W020" },
                    { 1086, "F18L1S116" },
                    { 1087, "F18L1W070" },
                    { 1088, "F18L1S120" },
                    { 1088, "F18L1W020" },
                    { 1084, "F18L1W020" },
                    { 2003, "F18L2W104" },
                    { 1251, "F18L1W020" },
                    { 1252, "F18L1S026" },
                    { 1422, "F18L1S052" },
                    { 1423, "F18L1S120" },
                    { 1423, "F18L1S026" },
                    { 1424, "F18L1S120" },
                    { 1424, "F18L1W007" },
                    { 1425, "F18L1W020" },
                    { 1425, "F18L1S052" },
                    { 1425, "F18L1S032" },
                    { 1425, "F18L1S146" },
                    { 1426, "F18L1W033" },
                    { 1427, "F18L1S016" },
                    { 1427, "F18L1W041" },
                    { 1428, "F18L1W007" },
                    { 1428, "F18L1S116" },
                    { 1428, "F18L1W005" },
                    { 1421, "F18L1W020" },
                    { 1421, "F18L1S032" },
                    { 1421, "F18L1W011" },
                    { 1420, "F18L1S032" },
                    { 1412, "F18L1S016" },
                    { 1412, "F18L1S116" },
                    { 1413, "F18L1S032" },
                    { 1414, "F18L1S045" },
                    { 1414, "F18L1S034" },
                    { 1414, "F18L1S120" },
                    { 1415, "F18L1S034" },
                    { 1429, "F18L1S013" },
                    { 1416, "F18L1W007" },
                    { 1417, "F18L1S034" },
                    { 1418, "F18L1S120" },
                    { 1419, "F18L1W031" },
                    { 1419, "F18L1W041" },
                    { 1419, "F18L1S003" },
                    { 1419, "F18L1S013" },
                    { 1420, "F18L1W011" },
                    { 1416, "F18L1W033" },
                    { 1411, "F18L1S015" },
                    { 1429, "F18L1S045" },
                    { 1430, "F18L1S032" },
                    { 1437, "F18L1S034" },
                    { 1438, "F18L1S016" },
                    { 1438, "F18L1S032" },
                    { 1438, "F18L1W031" },
                    { 1438, "F18L1S116" },
                    { 1439, "F18L1S034" },
                    { 1439, "F18L1W011" },
                    { 1439, "F18L1W033" },
                    { 1440, "F18L1W070" },
                    { 1440, "F18L1W031" },
                    { 1440, "F18L1S045" },
                    { 1440, "F18L1S034" },
                    { 1441, "F18L1W007" },
                    { 1442, "F18L1W041" },
                    { 1443, "F18L1W070" },
                    { 1436, "F18L1S016" },
                    { 1436, "F18L1S146" },
                    { 1436, "F18L1S045" },
                    { 1436, "F18L1S120" },
                    { 1430, "F18L1W049" },
                    { 1430, "F18L1S015" },
                    { 1431, "F18L1S003" },
                    { 1431, "F18L1S034" },
                    { 1432, "F18L1S015" },
                    { 1432, "F18L1S032" },
                    { 1432, "F18L1S003" },
                    { 1429, "F18L1W007" },
                    { 1433, "F18L1S023" },
                    { 1433, "F18L1S116" },
                    { 1434, "F18L1W031" },
                    { 1434, "F18L1S016" },
                    { 1434, "F18L1S026" },
                    { 1434, "F18L1S032" },
                    { 1435, "F18L1W031" },
                    { 1435, "F18L1S116" },
                    { 1433, "F18L1W033" },
                    { 1411, "F18L1S146" },
                    { 1411, "F18L1W011" },
                    { 1410, "F18L1S052" },
                    { 1388, "F18L1S015" },
                    { 1389, "F18L1S013" },
                    { 1389, "F18L1S052" },
                    { 1389, "F18L1W033" },
                    { 1389, "F18L1W005" },
                    { 1390, "F18L1W031" },
                    { 1390, "F18L1S116" },
                    { 1390, "F18L1S052" },
                    { 1391, "F18L1W020" },
                    { 1392, "F18L1S003" },
                    { 1392, "F18L1S034" },
                    { 1392, "F18L1S026" },
                    { 1392, "F18L1S013" },
                    { 1393, "F18L1W070" },
                    { 1393, "F18L1S146" },
                    { 1388, "F18L1S120" },
                    { 1388, "F18L1S052" },
                    { 1388, "F18L1S045" },
                    { 1387, "F18L1S116" },
                    { 1381, "F18L1S023" },
                    { 1381, "F18L1W020" },
                    { 1381, "F18L1W070" },
                    { 1381, "F18L1W049" },
                    { 1382, "F18L1W007" },
                    { 1382, "F18L1W033" },
                    { 1382, "F18L1S032" },
                    { 1394, "F18L1S146" },
                    { 1383, "F18L1W011" }
                });

            migrationBuilder.InsertData(
                table: "StudentiPolagaatPredmeti",
                columns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                values: new object[,]
                {
                    { 1384, "F18L1W005" },
                    { 1384, "F18L1W070" },
                    { 1385, "F18L1W041" },
                    { 1386, "F18L1W041" },
                    { 1386, "F18L1W033" },
                    { 1386, "F18L1S034" },
                    { 1387, "F18L1W007" },
                    { 1383, "F18L1S146" },
                    { 1394, "F18L1W033" },
                    { 1394, "F18L1S052" },
                    { 1395, "F18L1S120" },
                    { 1402, "F18L1S023" },
                    { 1402, "F18L1W011" },
                    { 1403, "F18L1W070" },
                    { 1404, "F18L1W007" },
                    { 1405, "F18L1S052" },
                    { 1405, "F18L1S120" },
                    { 1405, "F18L1S003" },
                    { 1402, "F18L1W020" },
                    { 1405, "F18L1W049" },
                    { 1407, "F18L1W041" },
                    { 1407, "F18L1S120" },
                    { 1408, "F18L1W007" },
                    { 1408, "F18L1S052" },
                    { 1409, "F18L1W070" },
                    { 1410, "F18L1S003" },
                    { 1410, "F18L1S023" },
                    { 1406, "F18L1S023" },
                    { 1443, "F18L1W033" },
                    { 1401, "F18L1S013" },
                    { 1401, "F18L1S052" },
                    { 1395, "F18L1S015" },
                    { 1395, "F18L1W005" },
                    { 1396, "F18L1S032" },
                    { 1397, "F18L1S045" },
                    { 1397, "F18L1W011" },
                    { 1397, "F18L1S052" },
                    { 1398, "F18L1W049" },
                    { 1401, "F18L1W031" },
                    { 1398, "F18L1W031" },
                    { 1399, "F18L1S116" },
                    { 1399, "F18L1S032" },
                    { 1399, "F18L1W033" },
                    { 1400, "F18L1W020" },
                    { 1400, "F18L1S013" },
                    { 1400, "F18L1S003" },
                    { 1400, "F18L1S034" },
                    { 1398, "F18L1W070" },
                    { 1444, "F18L1S016" },
                    { 1444, "F18L1S146" },
                    { 1444, "F18L1S116" },
                    { 1483, "F18L1W007" },
                    { 1484, "F18L1S034" },
                    { 1485, "F18L1S003" },
                    { 1486, "F18L1W033" },
                    { 1486, "F18L1S032" },
                    { 1486, "F18L1S120" },
                    { 1486, "F18L1S026" },
                    { 1487, "F18L1S052" },
                    { 1487, "F18L1W011" },
                    { 1488, "F18L1W011" },
                    { 1489, "F18L1S003" },
                    { 1489, "F18L1S146" },
                    { 1490, "F18L1S116" },
                    { 1490, "F18L1S013" },
                    { 1490, "F18L1S026" },
                    { 1483, "F18L1S116" },
                    { 1483, "F18L1S013" },
                    { 1482, "F18L1S026" },
                    { 1482, "F18L1W020" },
                    { 1475, "F18L1S003" },
                    { 1475, "F18L1S034" },
                    { 1475, "F18L1S032" },
                    { 1476, "F18L1W070" },
                    { 1476, "F18L1W005" },
                    { 1477, "F18L1W033" },
                    { 1477, "F18L1W049" },
                    { 1490, "F18L1S003" },
                    { 1477, "F18L1S016" },
                    { 1479, "F18L1S146" },
                    { 1479, "F18L1S023" },
                    { 1479, "F18L1S016" },
                    { 1480, "F18L1W070" },
                    { 1481, "F18L1S016" },
                    { 1481, "F18L1W007" },
                    { 1481, "F18L1W070" },
                    { 1478, "F18L1S045" },
                    { 1491, "F18L1W005" },
                    { 1491, "F18L1W041" },
                    { 1492, "F18L1S016" },
                    { 1499, "F18L1S026" },
                    { 2000, "F18L2W067" },
                    { 2000, "F18L2S119" },
                    { 2000, "F18L2W104" },
                    { 2000, "F18L2W167" },
                    { 2001, "F18L2W109" },
                    { 2001, "F18L2W006" },
                    { 1499, "F18L1S045" },
                    { 2001, "F18L2S119" },
                    { 2002, "F18L1S023" },
                    { 2002, "F18L2S084" },
                    { 2002, "F18L1S045" },
                    { 2002, "F18L1W007" },
                    { 2002, "F18L2S029" },
                    { 2002, "F18L2S017" },
                    { 2002, "F18L1S116" },
                    { 2002, "F18L2W167" },
                    { 1475, "F18L1W049" },
                    { 1499, "F18L1S120" },
                    { 1498, "F18L1W070" },
                    { 1493, "F18L1S034" },
                    { 1493, "F18L1W049" },
                    { 1493, "F18L1W031" },
                    { 1493, "F18L1W041" },
                    { 1494, "F18L1W005" },
                    { 1494, "F18L1W007" },
                    { 1494, "F18L1W049" },
                    { 1499, "F18L1W049" },
                    { 1494, "F18L1S003" },
                    { 1495, "F18L1S023" },
                    { 1495, "F18L1W070" },
                    { 1495, "F18L1S016" },
                    { 1496, "F18L1W005" },
                    { 1497, "F18L1S120" },
                    { 1497, "F18L1W005" },
                    { 1498, "F18L1S023" },
                    { 1495, "F18L1S026" },
                    { 1380, "F18L1S015" },
                    { 1474, "F18L1W049" },
                    { 1474, "F18L1S052" },
                    { 1452, "F18L1S026" },
                    { 1452, "F18L1S116" },
                    { 1453, "F18L1S016" },
                    { 1453, "F18L1S034" },
                    { 1454, "F18L1S023" },
                    { 1454, "F18L1W005" },
                    { 1454, "F18L1S052" },
                    { 1454, "F18L1W049" },
                    { 1455, "F18L1S015" },
                    { 1455, "F18L1W070" },
                    { 1455, "F18L1S120" },
                    { 1456, "F18L1W031" },
                    { 1456, "F18L1S045" },
                    { 1457, "F18L1S015" },
                    { 1457, "F18L1W031" },
                    { 1452, "F18L1W041" },
                    { 1451, "F18L1S032" },
                    { 1450, "F18L1S045" },
                    { 1450, "F18L1S032" },
                    { 1445, "F18L1S146" },
                    { 1445, "F18L1W070" },
                    { 1446, "F18L1S003" },
                    { 1446, "F18L1S026" },
                    { 1446, "F18L1S013" },
                    { 1447, "F18L1S013" },
                    { 1447, "F18L1W070" },
                    { 1458, "F18L1S146" },
                    { 1447, "F18L1W011" },
                    { 1448, "F18L1S146" },
                    { 1448, "F18L1S015" },
                    { 1448, "F18L1S016" },
                    { 1449, "F18L1S013" },
                    { 1449, "F18L1W049" },
                    { 1449, "F18L1S116" },
                    { 1450, "F18L1W031" },
                    { 1448, "F18L1S116" },
                    { 1458, "F18L1S016" },
                    { 1458, "F18L1W011" },
                    { 1458, "F18L1S052" },
                    { 1467, "F18L1S032" },
                    { 1467, "F18L1S146" },
                    { 1468, "F18L1S052" },
                    { 1468, "F18L1S045" },
                    { 1468, "F18L1S015" },
                    { 1468, "F18L1W049" },
                    { 1469, "F18L1S026" },
                    { 1466, "F18L1S116" },
                    { 1470, "F18L1W031" },
                    { 1471, "F18L1W049" },
                    { 1471, "F18L1S116" },
                    { 1471, "F18L1W011" },
                    { 1472, "F18L1W041" },
                    { 1472, "F18L1S023" },
                    { 1472, "F18L1S013" },
                    { 1473, "F18L1S015" },
                    { 1471, "F18L1S013" },
                    { 1474, "F18L1W031" },
                    { 1466, "F18L1W041" },
                    { 1465, "F18L1S003" },
                    { 1459, "F18L1W020" },
                    { 1460, "F18L1S003" },
                    { 1460, "F18L1S052" },
                    { 1460, "F18L1S120" },
                    { 1461, "F18L1W031" },
                    { 1462, "F18L1W041" },
                    { 1462, "F18L1S016" },
                    { 1466, "F18L1S032" },
                    { 1462, "F18L1S034" },
                    { 1463, "F18L1S045" },
                    { 1463, "F18L1W020" },
                    { 1463, "F18L1S023" },
                    { 1464, "F18L1W007" },
                    { 1464, "F18L1W031" },
                    { 1465, "F18L1W005" },
                    { 1465, "F18L1W049" },
                    { 1463, "F18L1S013" },
                    { 1380, "F18L1S120" },
                    { 1379, "F18L1W005" },
                    { 1379, "F18L1S052" },
                    { 1292, "F18L1W041" },
                    { 1292, "F18L1S052" },
                    { 1292, "F18L1W020" },
                    { 1293, "F18L1S034" },
                    { 1294, "F18L1S032" },
                    { 1294, "F18L1S052" },
                    { 1294, "F18L1W031" },
                    { 1295, "F18L1W041" },
                    { 1295, "F18L1S023" },
                    { 1295, "F18L1W007" },
                    { 1295, "F18L1W020" },
                    { 1296, "F18L1S045" },
                    { 1296, "F18L1W031" },
                    { 1296, "F18L1S052" },
                    { 1296, "F18L1S146" },
                    { 1291, "F18L1W033" },
                    { 1291, "F18L1W070" },
                    { 1290, "F18L1S032" },
                    { 1290, "F18L1W041" },
                    { 1283, "F18L1S146" },
                    { 1284, "F18L1W049" },
                    { 1284, "F18L1S023" },
                    { 1284, "F18L1W070" },
                    { 1285, "F18L1S026" },
                    { 1286, "F18L1S146" },
                    { 1287, "F18L1S003" },
                    { 1297, "F18L1W031" },
                    { 1287, "F18L1S146" },
                    { 1288, "F18L1S052" },
                    { 1288, "F18L1W005" },
                    { 1288, "F18L1S013" },
                    { 1289, "F18L1S052" },
                    { 1289, "F18L1W020" },
                    { 1290, "F18L1S120" },
                    { 1290, "F18L1W031" },
                    { 1287, "F18L1W007" },
                    { 1297, "F18L1S045" },
                    { 1298, "F18L1W007" },
                    { 1298, "F18L1W005" },
                    { 1306, "F18L1S013" },
                    { 1306, "F18L1S023" },
                    { 1306, "F18L1W007" },
                    { 1307, "F18L1W011" },
                    { 1308, "F18L1S032" },
                    { 1309, "F18L1W011" },
                    { 1310, "F18L1S116" },
                    { 1305, "F18L1W049" },
                    { 1310, "F18L1W011" },
                    { 1312, "F18L1S026" },
                    { 1313, "F18L1W041" },
                    { 1313, "F18L1S023" },
                    { 1313, "F18L1S026" },
                    { 1314, "F18L1W049" },
                    { 1314, "F18L1S013" },
                    { 1314, "F18L1W007" },
                    { 1311, "F18L1W033" },
                    { 1282, "F18L1S015" },
                    { 1305, "F18L1S032" },
                    { 1305, "F18L1W033" },
                    { 1298, "F18L1S013" },
                    { 1298, "F18L1W070" },
                    { 1299, "F18L1W007" },
                    { 1300, "F18L1W033" },
                    { 1300, "F18L1S116" },
                    { 1300, "F18L1S016" },
                    { 1300, "F18L1W005" },
                    { 1305, "F18L1S052" },
                    { 1301, "F18L1W020" },
                    { 1302, "F18L1W070" },
                    { 1302, "F18L1W049" },
                    { 1303, "F18L1S120" },
                    { 1303, "F18L1S015" },
                    { 1303, "F18L1W031" },
                    { 1304, "F18L1S023" },
                    { 1304, "F18L1W049" },
                    { 1302, "F18L1W033" },
                    { 1314, "F18L1S003" },
                    { 1282, "F18L1S023" },
                    { 1280, "F18L1W033" },
                    { 1259, "F18L1S013" },
                    { 1259, "F18L1S032" },
                    { 1259, "F18L1S045" },
                    { 1259, "F18L1S146" },
                    { 1260, "F18L1W005" },
                    { 1260, "F18L1S045" },
                    { 1260, "F18L1W070" },
                    { 1260, "F18L1S013" },
                    { 1261, "F18L1S034" },
                    { 1261, "F18L1W049" },
                    { 1261, "F18L1S052" },
                    { 1261, "F18L1W031" },
                    { 1262, "F18L1W020" },
                    { 1263, "F18L1W049" },
                    { 1263, "F18L1W020" },
                    { 1258, "F18L1S015" },
                    { 1258, "F18L1W033" },
                    { 1258, "F18L1S023" },
                    { 1257, "F18L1S120" },
                    { 1253, "F18L1W007" },
                    { 1253, "F18L1S032" },
                    { 1253, "F18L1S023" },
                    { 1253, "F18L1W049" },
                    { 1254, "F18L1W007" },
                    { 1254, "F18L1S026" },
                    { 1254, "F18L1W020" },
                    { 1263, "F18L1S116" },
                    { 1254, "F18L1S045" },
                    { 1255, "F18L1W041" },
                    { 1255, "F18L1W005" },
                    { 1255, "F18L1S016" },
                    { 1256, "F18L1S052" },
                    { 1256, "F18L1S013" },
                    { 1257, "F18L1W005" },
                    { 1257, "F18L1S146" },
                    { 1255, "F18L1W049" },
                    { 1263, "F18L1W031" },
                    { 1264, "F18L1S034" },
                    { 1265, "F18L1S032" },
                    { 1275, "F18L1S016" },
                    { 1276, "F18L1S045" },
                    { 1276, "F18L1S023" },
                    { 1276, "F18L1W011" },
                    { 1276, "F18L1S052" },
                    { 1277, "F18L1W007" },
                    { 1278, "F18L1W007" },
                    { 1275, "F18L1W041" },
                    { 1278, "F18L1W070" },
                    { 1278, "F18L1S120" },
                    { 1279, "F18L1S045" },
                    { 1279, "F18L1W007" },
                    { 1279, "F18L1S016" },
                    { 1279, "F18L1S013" },
                    { 1280, "F18L1W070" },
                    { 1280, "F18L1W005" },
                    { 1278, "F18L1W011" },
                    { 1281, "F18L1W007" },
                    { 1274, "F18L1S146" },
                    { 1274, "F18L1W041" },
                    { 1265, "F18L1S120" },
                    { 1265, "F18L1W007" },
                    { 1265, "F18L1S015" },
                    { 1266, "F18L1S045" },
                    { 1267, "F18L1S034" },
                    { 1268, "F18L1W033" },
                    { 1269, "F18L1W011" },
                    { 1274, "F18L1S120" },
                    { 1270, "F18L1W020" },
                    { 1270, "F18L1S052" },
                    { 1270, "F18L1W031" },
                    { 1271, "F18L1W011" },
                    { 1271, "F18L1S146" },
                    { 1271, "F18L1W070" },
                    { 1272, "F18L1W049" },
                    { 1273, "F18L1S032" },
                    { 1270, "F18L1W070" },
                    { 1252, "F18L1S016" },
                    { 1315, "F18L1S032" },
                    { 1315, "F18L1W005" },
                    { 1357, "F18L1W070" },
                    { 1357, "F18L1S034" },
                    { 1358, "F18L1S052" },
                    { 1358, "F18L1W033" },
                    { 1358, "F18L1W007" },
                    { 1359, "F18L1W005" },
                    { 1359, "F18L1S120" },
                    { 1360, "F18L1W007" },
                    { 1360, "F18L1W041" },
                    { 1360, "F18L1S116" },
                    { 1360, "F18L1W031" },
                    { 1361, "F18L1W005" },
                    { 1361, "F18L1S013" },
                    { 1361, "F18L1W070" },
                    { 1361, "F18L1S016" },
                    { 1356, "F18L1S034" },
                    { 1356, "F18L1S032" },
                    { 1355, "F18L1S023" },
                    { 1355, "F18L1W041" },
                    { 1350, "F18L1S013" },
                    { 1351, "F18L1W031" },
                    { 1351, "F18L1W007" },
                    { 1351, "F18L1S015" },
                    { 1352, "F18L1S116" },
                    { 1352, "F18L1S032" },
                    { 1352, "F18L1S034" },
                    { 1362, "F18L1W070" },
                    { 1353, "F18L1S023" },
                    { 1353, "F18L1S120" },
                    { 1353, "F18L1S146" },
                    { 1354, "F18L1W041" },
                    { 1354, "F18L1S146" },
                    { 1354, "F18L1S120" },
                    { 1354, "F18L1W007" },
                    { 1355, "F18L1W049" },
                    { 1353, "F18L1W031" },
                    { 1363, "F18L1S034" },
                    { 1363, "F18L1S045" },
                    { 1364, "F18L1W020" },
                    { 1374, "F18L1W020" },
                    { 1375, "F18L1S052" },
                    { 1375, "F18L1S016" },
                    { 1375, "F18L1S120" },
                    { 1376, "F18L1W005" },
                    { 1376, "F18L1W070" },
                    { 1376, "F18L1W031" },
                    { 1374, "F18L1W070" },
                    { 1376, "F18L1W033" },
                    { 1377, "F18L1W049" },
                    { 1377, "F18L1W007" },
                    { 1378, "F18L1S045" },
                    { 1378, "F18L1S032" },
                    { 1378, "F18L1S146" },
                    { 1378, "F18L1S023" },
                    { 1379, "F18L1S116" },
                    { 1377, "F18L1W041" },
                    { 1350, "F18L1S026" },
                    { 1374, "F18L1S015" },
                    { 1373, "F18L1S120" },
                    { 1365, "F18L1W005" },
                    { 1366, "F18L1S015" },
                    { 1366, "F18L1S116" },
                    { 1367, "F18L1S015" },
                    { 1368, "F18L1S013" },
                    { 1369, "F18L1S026" },
                    { 1370, "F18L1S015" },
                    { 1374, "F18L1S052" },
                    { 1370, "F18L1W005" },
                    { 1371, "F18L1W070" },
                    { 1371, "F18L1S023" },
                    { 1371, "F18L1S052" },
                    { 1372, "F18L1S052" },
                    { 1372, "F18L1S023" },
                    { 1373, "F18L1W007" },
                    { 1373, "F18L1S052" },
                    { 1371, "F18L1W031" },
                    { 1315, "F18L1S034" },
                    { 1349, "F18L1S032" },
                    { 1349, "F18L1S016" },
                    { 1323, "F18L1S016" },
                    { 1323, "F18L1W049" },
                    { 1323, "F18L1W031" },
                    { 1324, "F18L1S146" },
                    { 1324, "F18L1W005" },
                    { 1325, "F18L1S023" },
                    { 1325, "F18L1W005" },
                    { 1326, "F18L1S015" },
                    { 1326, "F18L1S023" },
                    { 1326, "F18L1S034" },
                    { 1327, "F18L1W033" },
                    { 1327, "F18L1W007" },
                    { 1327, "F18L1W049" },
                    { 1327, "F18L1S032" },
                    { 1328, "F18L1S016" },
                    { 1323, "F18L1W007" },
                    { 1322, "F18L1S032" },
                    { 1322, "F18L1S116" },
                    { 1322, "F18L1S026" },
                    { 1316, "F18L1W020" },
                    { 1316, "F18L1W041" },
                    { 1316, "F18L1S034" },
                    { 1316, "F18L1W070" },
                    { 1317, "F18L1W033" },
                    { 1318, "F18L1S026" },
                    { 1318, "F18L1W011" },
                    { 1329, "F18L1W041" },
                    { 1319, "F18L1S034" },
                    { 1319, "F18L1S026" },
                    { 1320, "F18L1S026" },
                    { 1320, "F18L1S034" },
                    { 1320, "F18L1S013" },
                    { 1321, "F18L1W007" },
                    { 1321, "F18L1W070" },
                    { 1321, "F18L1W033" },
                    { 1319, "F18L1S032" },
                    { 1330, "F18L1W011" },
                    { 1330, "F18L1W033" },
                    { 1330, "F18L1S016" },
                    { 1340, "F18L1W020" },
                    { 1340, "F18L1S120" },
                    { 1341, "F18L1W070" },
                    { 1341, "F18L1W041" },
                    { 1342, "F18L1W011" },
                    { 1343, "F18L1S052" },
                    { 1344, "F18L1W070" },
                    { 1339, "F18L1S032" },
                    { 1344, "F18L1W041" },
                    { 1344, "F18L1W020" },
                    { 1345, "F18L1S013" },
                    { 1345, "F18L1S023" },
                    { 1346, "F18L1S026" },
                    { 1347, "F18L1W011" },
                    { 1348, "F18L1W011" },
                    { 1349, "F18L1S015" },
                    { 1344, "F18L1W049" },
                    { 1349, "F18L1W070" },
                    { 1339, "F18L1S003" },
                    { 1339, "F18L1S013" },
                    { 1331, "F18L1S015" },
                    { 1332, "F18L1W031" },
                    { 1333, "F18L1W049" },
                    { 1333, "F18L1S023" },
                    { 1334, "F18L1S034" },
                    { 1335, "F18L1S045" },
                    { 1335, "F18L1S120" },
                    { 1339, "F18L1S146" },
                    { 1335, "F18L1S015" },
                    { 1336, "F18L1S034" },
                    { 1336, "F18L1S052" },
                    { 1337, "F18L1S034" },
                    { 1338, "F18L1S013" },
                    { 1338, "F18L1W049" },
                    { 1338, "F18L1W070" },
                    { 1338, "F18L1W005" },
                    { 1335, "F18L1W007" },
                    { 4049, "F18L3S077" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1000, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1001, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1001, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1001, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1002, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1002, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1002, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1002, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1003, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1003, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1004, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1004, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1005, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1005, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1006, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1006, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1006, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1007, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1007, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1007, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1007, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1008, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1008, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1008, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1009, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1010, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1010, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1010, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1011, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1011, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1011, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1011, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1012, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1012, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1012, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1013, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1013, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1013, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1014, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1014, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1014, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1015, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1015, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1016, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1016, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1016, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1016, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1017, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1017, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1017, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1018, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1019, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1020, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1021, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1022, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1022, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1023, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1023, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1023, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1024, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1024, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1025, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1025, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1026, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1026, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1027, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1027, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1027, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1027, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1028, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1029, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1029, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1030, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1030, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1030, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1031, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1031, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1032, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1032, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1032, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1032, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1033, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1033, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1033, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1034, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1034, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1034, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1035, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1035, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1035, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1036, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1036, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1036, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1037, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1038, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1038, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1039, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1039, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1039, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1039, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1040, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1040, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1040, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1040, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1041, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1042, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1042, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1043, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1044, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1044, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1044, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1044, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1045, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1045, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1046, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1046, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1046, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1047, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1047, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1047, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1048, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1048, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1049, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1049, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1049, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1049, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1050, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1050, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1051, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1052, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1053, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1053, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1053, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1053, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1054, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1054, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1054, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1054, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1055, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1055, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1055, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1055, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1056, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1056, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1057, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1058, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1058, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1058, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1058, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1059, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1060, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1061, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1061, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1061, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1061, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1062, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1062, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1062, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1062, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1063, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1064, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1064, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1065, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1065, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1066, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1066, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1067, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1067, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1068, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1068, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1069, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1069, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1069, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1070, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1070, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1071, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1072, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1073, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1074, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1075, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1075, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1075, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1075, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1076, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1076, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1077, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1078, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1078, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1079, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1079, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1079, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1080, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1080, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1081, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1081, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1081, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1081, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1082, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1082, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1083, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1083, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1083, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1083, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1084, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1084, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1084, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1084, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1085, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1085, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1085, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1086, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1087, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1088, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1088, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1088, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1089, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1089, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1090, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1090, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1091, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1091, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1091, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1091, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1092, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1092, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1092, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1092, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1093, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1093, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1093, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1094, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1094, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1094, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1094, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1095, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1096, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1096, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1096, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1096, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1097, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1098, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1098, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1098, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1098, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1099, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1099, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1100, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1100, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1101, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1101, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1101, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1102, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1102, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1102, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1103, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1103, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1103, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1103, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1104, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1104, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1104, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1104, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1105, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1105, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1105, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1106, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1106, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1107, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1107, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1107, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1108, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1108, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1108, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1108, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1109, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1109, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1110, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1111, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1111, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1112, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1112, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1113, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1113, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1113, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1113, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1114, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1114, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1115, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1115, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1115, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1115, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1116, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1116, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1117, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1117, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1117, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1118, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1119, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1120, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1120, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1120, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1121, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1121, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1121, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1121, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1122, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1122, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1123, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1124, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1125, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1125, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1126, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1127, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1127, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1128, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1128, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1128, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1128, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1129, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1129, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1129, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1129, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1130, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1130, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1130, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1130, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1131, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1132, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1133, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1134, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1134, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1135, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1135, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1135, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1136, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1136, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1136, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1137, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1137, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1137, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1138, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1139, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1140, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1141, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1141, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1141, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1141, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1142, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1142, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1142, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1143, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1143, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1143, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1143, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1144, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1145, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1145, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1145, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1145, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1146, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1147, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1147, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1147, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1147, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1148, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1148, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1148, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1148, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1149, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1149, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1149, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1149, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1150, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1151, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1151, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1151, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1152, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1152, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1152, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1153, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1153, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1154, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1155, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1155, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1155, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1155, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1156, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1157, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1157, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1157, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1157, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1158, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1159, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1159, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1159, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1160, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1161, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1162, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1163, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1163, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1163, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1163, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1164, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1164, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1165, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1165, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1165, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1166, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1166, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1166, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1166, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1167, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1167, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1168, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1168, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1169, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1169, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1169, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1169, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1170, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1170, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1170, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1170, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1171, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1171, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1172, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1172, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1173, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1174, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1174, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1174, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1174, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1175, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1176, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1176, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1176, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1176, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1177, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1177, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1177, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1177, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1178, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1178, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1178, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1179, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1179, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1179, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1179, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1180, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1180, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1180, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1181, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1181, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1181, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1182, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1183, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1183, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1183, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1184, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1184, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1185, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1186, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1186, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1186, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1187, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1187, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1188, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1188, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1188, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1189, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1190, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1191, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1191, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1191, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1192, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1192, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1192, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1193, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1194, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1195, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1196, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1196, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1197, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1197, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1197, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1197, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1198, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1199, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1199, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1199, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1199, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1200, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1201, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1201, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1201, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1201, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1202, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1202, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1202, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1203, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1204, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1205, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1205, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1206, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1206, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1206, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1207, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1208, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1208, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1208, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1209, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1209, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1209, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1209, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1210, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1210, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1210, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1211, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1211, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1211, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1211, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1212, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1212, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1212, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1212, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1213, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1214, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1214, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1215, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1215, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1215, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1215, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1216, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1216, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1216, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1217, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1218, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1218, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1218, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1219, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1219, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1220, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1220, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1220, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1221, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1221, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1221, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1222, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1222, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1222, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1223, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1223, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1223, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1223, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1224, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1224, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1224, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1224, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1225, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1225, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1226, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1226, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1227, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1228, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1228, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1229, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1229, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1230, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1230, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1230, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1230, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1231, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1231, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1231, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1231, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1232, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1232, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1232, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1233, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1233, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1233, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1233, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1234, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1235, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1235, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1235, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1236, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1237, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1237, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1237, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1238, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1238, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1238, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1239, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1239, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1240, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1241, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1241, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1241, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1241, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1242, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1242, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1242, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1243, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1243, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1243, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1244, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1244, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1244, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1244, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1245, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1245, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1246, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1246, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1246, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1246, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1247, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1248, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1248, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1248, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1248, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1249, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1250, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1250, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1250, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1250, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1251, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1251, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1251, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1251, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1252, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1252, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1253, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1253, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1253, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1253, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1254, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1254, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1254, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1254, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1255, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1255, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1255, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1255, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1256, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1256, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1257, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1257, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1257, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1258, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1258, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1258, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1259, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1259, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1259, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1259, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1260, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1260, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1260, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1260, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1261, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1261, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1261, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1261, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1262, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1263, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1263, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1263, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1263, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1264, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1265, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1265, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1265, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1265, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1266, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1267, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1268, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1269, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1270, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1270, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1270, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1270, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1271, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1271, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1271, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1272, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1273, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1274, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1274, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1274, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1275, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1275, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1276, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1276, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1276, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1276, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1277, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1278, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1278, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1278, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1278, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1279, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1279, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1279, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1279, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1280, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1280, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1280, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1281, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1282, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1282, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1283, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1284, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1284, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1284, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1285, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1286, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1287, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1287, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1287, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1288, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1288, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1288, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1289, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1289, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1290, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1290, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1290, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1290, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1291, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1291, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1292, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1292, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1292, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1293, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1294, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1294, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1294, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1295, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1295, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1295, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1295, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1296, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1296, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1296, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1296, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1297, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1297, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1298, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1298, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1298, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1298, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1299, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1300, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1300, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1300, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1300, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1301, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1302, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1302, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1302, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1303, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1303, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1303, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1304, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1304, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1305, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1305, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1305, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1305, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1306, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1306, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1306, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1307, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1308, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1309, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1310, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1310, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1311, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1312, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1313, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1313, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1313, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1314, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1314, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1314, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1314, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1315, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1315, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1315, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1316, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1316, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1316, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1316, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1317, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1318, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1318, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1319, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1319, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1319, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1320, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1320, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1320, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1321, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1321, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1321, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1322, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1322, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1322, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1323, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1323, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1323, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1323, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1324, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1324, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1325, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1325, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1326, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1326, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1326, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1327, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1327, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1327, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1327, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1328, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1329, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1330, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1330, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1330, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1331, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1332, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1333, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1333, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1334, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1335, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1335, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1335, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1335, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1336, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1336, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1337, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1338, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1338, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1338, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1338, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1339, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1339, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1339, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1339, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1340, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1340, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1341, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1341, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1342, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1343, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1344, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1344, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1344, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1344, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1345, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1345, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1346, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1347, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1348, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1349, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1349, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1349, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1349, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1350, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1350, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1351, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1351, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1351, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1352, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1352, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1352, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1353, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1353, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1353, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1353, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1354, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1354, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1354, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1354, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1355, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1355, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1355, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1356, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1356, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1357, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1357, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1358, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1358, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1358, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1359, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1359, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1360, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1360, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1360, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1360, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1361, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1361, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1361, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1361, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1362, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1363, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1363, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1364, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1365, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1366, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1366, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1367, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1368, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1369, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1370, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1370, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1371, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1371, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1371, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1371, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1372, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1372, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1373, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1373, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1373, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1374, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1374, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1374, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1374, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1375, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1375, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1375, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1376, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1376, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1376, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1376, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1377, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1377, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1377, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1378, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1378, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1378, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1378, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1379, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1379, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1379, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1380, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1380, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1381, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1381, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1381, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1381, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1382, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1382, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1382, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1383, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1383, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1384, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1384, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1385, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1386, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1386, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1386, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1387, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1387, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1388, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1388, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1388, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1388, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1389, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1389, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1389, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1389, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1390, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1390, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1390, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1391, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1392, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1392, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1392, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1392, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1393, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1393, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1394, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1394, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1394, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1395, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1395, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1395, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1396, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1397, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1397, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1397, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1398, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1398, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1398, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1399, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1399, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1399, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1400, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1400, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1400, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1400, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1401, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1401, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1401, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1402, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1402, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1402, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1403, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1404, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1405, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1405, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1405, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1405, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1406, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1407, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1407, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1408, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1408, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1409, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1410, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1410, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1410, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1411, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1411, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1411, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1412, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1412, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1413, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1414, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1414, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1414, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1415, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1416, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1416, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1417, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1418, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1419, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1419, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1419, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1419, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1420, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1420, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1421, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1421, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1421, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1422, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1423, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1423, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1424, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1424, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1425, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1425, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1425, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1425, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1426, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1427, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1427, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1428, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1428, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1428, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1429, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1429, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1429, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1430, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1430, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1430, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1431, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1431, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1432, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1432, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1432, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1433, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1433, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1433, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1434, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1434, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1434, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1434, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1435, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1435, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1436, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1436, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1436, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1436, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1437, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1438, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1438, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1438, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1438, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1439, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1439, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1439, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1440, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1440, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1440, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1440, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1441, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1442, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1443, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1443, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1444, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1444, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1444, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1445, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1445, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1446, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1446, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1446, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1447, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1447, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1447, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1448, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1448, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1448, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1448, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1449, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1449, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1449, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1450, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1450, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1450, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1451, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1452, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1452, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1452, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1453, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1453, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1454, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1454, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1454, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1454, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1455, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1455, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1455, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1456, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1456, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1457, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1457, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1458, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1458, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1458, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1458, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1459, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1460, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1460, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1460, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1461, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1462, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1462, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1462, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1463, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1463, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1463, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1463, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1464, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1464, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1465, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1465, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1465, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1466, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1466, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1466, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1467, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1467, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1468, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1468, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1468, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1468, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1469, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1470, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1471, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1471, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1471, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1471, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1472, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1472, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1472, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1473, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1474, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1474, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1474, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1475, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1475, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1475, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1475, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1476, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1476, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1477, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1477, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1477, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1478, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1479, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1479, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1479, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1480, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1481, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1481, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1481, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1482, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1482, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1483, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1483, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1483, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1484, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1485, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1486, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1486, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1486, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1486, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1487, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1487, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1488, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1489, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1489, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1490, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1490, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1490, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1490, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1491, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1491, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1492, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1493, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1493, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1493, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1493, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1494, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1494, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1494, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1494, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1495, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1495, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1495, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1495, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1496, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1497, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1497, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1498, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1498, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1499, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1499, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1499, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 1499, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2000, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2000, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2000, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2000, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2001, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2001, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2001, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2002, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2003, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2004, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2004, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2004, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2004, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2005, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2005, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2006, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2006, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2007, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2007, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2007, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2007, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2008, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2008, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2008, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2009, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2009, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2010, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2010, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2010, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2011, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2011, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2011, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2011, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2012, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2013, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2014, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2014, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2014, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2014, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2015, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2015, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2016, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2016, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2016, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2016, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2017, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2018, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2019, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2020, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2021, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2021, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2021, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2021, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2022, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2022, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2022, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2022, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2023, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2023, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2024, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2024, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2025, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2026, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2026, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2027, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2027, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2027, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2028, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2028, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2029, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2030, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2031, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2032, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2032, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2032, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2033, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2034, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2034, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2034, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2034, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2034, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2034, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2035, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2036, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2037, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2038, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2038, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2039, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2040, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2041, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2042, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2042, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2042, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2043, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2043, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2043, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2043, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2044, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2044, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2044, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2044, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2045, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2045, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2045, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2045, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2046, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2047, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2048, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2048, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2048, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2048, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2049, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2050, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2050, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2050, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2050, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2051, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2051, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2051, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2051, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2052, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2053, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2053, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2053, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2054, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2054, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2054, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2054, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2054, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2055, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2055, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2055, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2056, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2057, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2057, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2057, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2057, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2058, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2059, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2060, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2060, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2061, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2061, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2061, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2061, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2061, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2062, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2062, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2062, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2062, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2063, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2064, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2065, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2065, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2066, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2066, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2066, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2066, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2067, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2067, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2067, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2067, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2068, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2069, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2069, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2069, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2069, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2069, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2070, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2070, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2070, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2071, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2072, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2073, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2073, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2073, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2073, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2074, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2075, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2075, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2075, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2076, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2077, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2077, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2077, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2077, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2078, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2078, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2078, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2078, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2078, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2078, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2078, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2079, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2079, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2079, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2080, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2080, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2080, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2080, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2081, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2081, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2081, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2082, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2082, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2083, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2083, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2083, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2084, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2084, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2084, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2084, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2084, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2084, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2085, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2086, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2086, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2087, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2087, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2087, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2088, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2089, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2090, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2091, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2091, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2092, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2092, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2092, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2092, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2092, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2093, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2093, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2093, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2094, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2095, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2095, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2096, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2096, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2096, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2096, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2097, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2098, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2099, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2099, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2100, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2101, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2102, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2102, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2103, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2103, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2103, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2103, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2103, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2103, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2104, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2105, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2106, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L1S016" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2107, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2108, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2108, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2109, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2109, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2109, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2110, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2111, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2111, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2111, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2112, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2112, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2113, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2113, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2113, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2114, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2114, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2114, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2115, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2115, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2116, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2116, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2116, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2116, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2117, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2118, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2119, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2119, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2119, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2119, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2120, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2120, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2121, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2121, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2121, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2121, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2121, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2122, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2122, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2122, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2123, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2123, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2123, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2123, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2124, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2124, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2124, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2124, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2124, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2124, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2125, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2125, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2125, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2125, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2126, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2126, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2126, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2126, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2127, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2127, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2127, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2127, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2127, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2128, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2128, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2129, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2129, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2129, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2130, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2130, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2130, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2130, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2131, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2131, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2131, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2131, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2132, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2133, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2133, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2134, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2134, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2135, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2135, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2135, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2135, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2136, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2137, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2138, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2138, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2138, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2139, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2140, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2140, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2140, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2140, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2141, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2141, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2141, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2141, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2142, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2142, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2143, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2144, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2144, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2144, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2145, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2145, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2146, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2146, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2146, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2146, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2147, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2147, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2147, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2147, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2148, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2148, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2148, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2148, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2149, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2149, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2149, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2150, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2150, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2151, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2152, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2153, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2153, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2154, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2154, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2154, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2154, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2155, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2155, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2155, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2156, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2156, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2157, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2158, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2158, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2159, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2159, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2159, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2160, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2160, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2161, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2161, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2161, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2162, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2163, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2163, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2163, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2164, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2165, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2165, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2166, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2166, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2167, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2168, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2168, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2169, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2169, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2169, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2169, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2169, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2170, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2170, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2171, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2171, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2171, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2171, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2172, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2172, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2172, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2173, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2173, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2173, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2173, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2174, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2175, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2176, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2176, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2176, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2176, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2176, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2176, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2176, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2177, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2177, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2177, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2177, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2178, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2179, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2179, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2179, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2180, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2180, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2180, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2181, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2181, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2181, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2181, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2182, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2183, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2184, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2185, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2185, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2185, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2186, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2186, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2187, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2187, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2187, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2187, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2188, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2188, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2188, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2189, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2189, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2189, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2190, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2190, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2190, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2190, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2191, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2191, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2191, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2192, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2193, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2193, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2193, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2193, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2194, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2195, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2195, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2195, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2195, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2195, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2196, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2196, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2196, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2196, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L1S023" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2197, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2198, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2198, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2199, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2199, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2199, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2200, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2200, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2200, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2201, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2201, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2201, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2201, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2202, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2202, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2203, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2203, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2204, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2204, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2204, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2205, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2205, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2205, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2206, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2206, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2207, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2207, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2207, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2208, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2208, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2209, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2210, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2210, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2210, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2210, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L1S146" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2211, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2212, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2213, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2213, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2213, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2213, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2214, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2215, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2215, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2215, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2216, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2216, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2216, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2216, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2217, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2217, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2217, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2217, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2218, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2218, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2218, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2219, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2219, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2219, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2220, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2220, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2220, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2221, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2222, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2222, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2222, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2222, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2223, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2223, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2224, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2224, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2224, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2225, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2226, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2227, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2228, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2228, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2228, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2228, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2228, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2229, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2230, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2230, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2231, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2231, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2231, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2232, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L1S026" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L1W033" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L1W049" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2233, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L1S003" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L1W011" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2234, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2235, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2235, "F18L2S097" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2235, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2235, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2236, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2236, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2236, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2237, "F18L2S082" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2238, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2238, "F18L1S052" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2238, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2238, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2238, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2238, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2238, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2239, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2239, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2239, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2240, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2240, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2240, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2241, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2241, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2241, "F18L2S119" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2241, "F18L2W006" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2242, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2243, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2243, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2244, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2244, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2245, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2246, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2246, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L1W031" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L2S084" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L2W067" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L2W140" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2247, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2248, "F18L2S029" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2248, "F18L2S030" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2248, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 2249, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3000, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3000, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3000, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3000, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3001, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3001, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3001, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3002, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3003, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3003, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3003, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3003, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3004, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3004, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3004, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3004, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3005, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3005, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3005, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3006, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3006, "F18L3S135" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3006, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3006, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3007, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3008, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3008, "F18L3W009" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3009, "F18L3S138" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3009, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3009, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3009, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3010, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3010, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3010, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3011, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3011, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3011, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3012, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3013, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3014, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3015, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3016, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3016, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3017, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3017, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3017, "F18L3W009" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3017, "F18L3W027" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3018, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3018, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3019, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3020, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3020, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3021, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3021, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3022, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3022, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3023, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3023, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3024, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3025, "F18L1S015" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3025, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3025, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3025, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3025, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3025, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3025, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3026, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3026, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3026, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3026, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3027, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3027, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3027, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3028, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3028, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3028, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3029, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3029, "F18L3W009" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3030, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3030, "F18L3W027" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3030, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3030, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3031, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3032, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3032, "F18L3S138" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3032, "F18L3W009" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3032, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3033, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3034, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3034, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3034, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3034, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3035, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3036, "F18L3W027" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3036, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3037, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3037, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3037, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3038, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L1W041" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L2S002" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L2S017" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L2W046" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L3S135" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3039, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3040, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3040, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3040, "F18L3S135" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3041, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3041, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3041, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3041, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3042, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3042, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3043, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3043, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3043, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3044, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3044, "F18L3S135" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3044, "F18L3S166" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3044, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L2S100" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L2S110" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L3W027" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3045, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3046, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3046, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3047, "F18L3S135" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3047, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3047, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3047, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3048, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3048, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3048, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3049, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3050, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3050, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3050, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3050, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3051, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3051, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3052, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3052, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3052, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3052, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3053, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3053, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3054, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3054, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3054, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3055, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3056, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3056, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3056, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3057, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3058, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3058, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3058, "F18L3W027" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3059, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3059, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3059, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3059, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3060, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3060, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3060, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3061, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3061, "F18L3W027" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3062, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3062, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L1S034" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L1W007" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L2W167" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L3S010" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L3S135" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3063, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3064, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3064, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3064, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3065, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3065, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3065, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3065, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3066, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3066, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3066, "F18L3W009" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3067, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3067, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3067, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3068, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3069, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3069, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3070, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3070, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3071, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3072, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3073, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3073, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3073, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3074, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3074, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3074, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3075, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3075, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3075, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3075, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3076, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3076, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3076, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3077, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3077, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3077, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3077, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3078, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3079, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3080, "F18L3S138" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3080, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3080, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3080, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3081, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3082, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3082, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3082, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3083, "F18L3S166" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3083, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3083, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3083, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3084, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3084, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3084, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3085, "F18L3S166" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3085, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3086, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3086, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3086, "F18L3S166" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3086, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3087, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3088, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3088, "F18L3W009" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3088, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3089, "F18L3S130" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3090, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3090, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3090, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3090, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3091, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3092, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L3S138" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L3S166" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3093, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3094, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3095, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3095, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3095, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3096, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3096, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3096, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3097, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3098, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3099, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3100, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3100, "F18L3W027" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3101, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3101, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3101, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3102, "F18L1W020" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3102, "F18L2W104" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3102, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3102, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3102, "F18L3S118" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3102, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3102, "F18L3W043" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3103, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3103, "F18L3S135" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3103, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3104, "F18L3S138" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3104, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3104, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3105, "F18L3S040" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3106, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3107, "F18L3S138" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3107, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3107, "F18L3W009" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3107, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3108, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3109, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3109, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3109, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3109, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3110, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3110, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3110, "F18L3W035" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3110, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3111, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3111, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3111, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3111, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3112, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3112, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3113, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3113, "F18L3S122" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3113, "F18L3W064" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3114, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3114, "F18L3S036" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3114, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3114, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3115, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3116, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3116, "F18L3S157" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3116, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3116, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3117, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3117, "F18L3S138" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3117, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3117, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3118, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3119, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3119, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3119, "F18L3W024" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3120, "F18L3S059" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3120, "F18L3S063" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3120, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3120, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3121, "F18L3S019" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3121, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3122, "F18L3S094" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3122, "F18L3W004" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3122, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3122, "F18L3W134" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3123, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3123, "F18L3W050" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3124, "F18L3S025" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3124, "F18L3S091" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 3124, "F18L3W044" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4000, "F18L3S155" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4000, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4000, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4001, "F18L3S077" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4001, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L1S032" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L1S120" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L1W005" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L1W070" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L2S124" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L3W008" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4002, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4003, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4004, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4004, "F18L3W075" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4004, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4005, "F18L3W037" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4005, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4006, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4007, "F18L3W075" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4007, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4008, "F18L3S086" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4008, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4008, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4009, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4009, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4010, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4010, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4010, "F18L3W075" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4011, "F18L3S022" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4012, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4012, "F18L3W075" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4012, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4012, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4013, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4013, "F18L3W103" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4014, "F18L3S155" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4014, "F18L3W037" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4014, "F18L3W075" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4014, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4015, "F18L3W037" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4016, "F18L3S022" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4016, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4017, "F18L3W037" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4017, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4018, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4018, "F18L3W137" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4019, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4019, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4020, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4020, "F18L3W037" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4020, "F18L3W075" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4021, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4021, "F18L3W037" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4022, "F18L3S086" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4022, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4022, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4023, "F18L3S077" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4023, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4023, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4023, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4024, "F18L3S086" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4025, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4025, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4025, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4025, "F18L3W137" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4026, "F18L3W103" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4027, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4028, "F18L3S022" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4028, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4028, "F18L3W037" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4028, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4029, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4029, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4030, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4030, "F18L3S077" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4030, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L1S013" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L1S045" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L1S116" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L2S099" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L2W001" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L2W109" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L3S141" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L3W085" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4031, "F18L3W136" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4032, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4032, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4032, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4032, "F18L3W137" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4033, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4034, "F18L3S155" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4034, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4035, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4036, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4037, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4037, "F18L3S155" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4037, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4038, "F18L3S086" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4038, "F18L3W075" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4038, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4038, "F18L3W103" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4039, "F18L3S086" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4039, "F18L3W103" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4039, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4039, "F18L3W137" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4040, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4041, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4041, "F18L3W103" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4041, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4041, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4042, "F18L3S022" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4042, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4043, "F18L3S022" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4043, "F18L3S155" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4043, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4043, "F18L3W129" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4044, "F18L3S086" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4044, "F18L3S155" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4044, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4045, "F18L3S028" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4045, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4045, "F18L3W103" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4045, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4046, "F18L3S077" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4046, "F18L3W079" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4046, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4047, "F18L3W060" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4048, "F18L3S022" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4048, "F18L3S107" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4048, "F18L3W126" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4049, "F18L3S022" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4049, "F18L3S077" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4049, "F18L3S086" });

            migrationBuilder.DeleteData(
                table: "StudentiPolagaatPredmeti",
                keyColumns: new[] { "BrojNaIndeks", "KodNaPredmet" },
                keyValues: new object[] { 4049, "F18L3W105" });

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3004);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3005);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3006);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3007);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3008);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3009);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3011);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3012);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3013);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3014);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3015);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3016);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3017);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3018);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3019);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3024);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3025);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3026);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3027);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3028);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3029);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3030);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3031);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3032);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3033);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3034);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3035);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3036);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3037);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3038);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3039);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3040);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3041);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3042);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3043);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3044);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3045);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3046);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3047);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3048);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3049);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3050);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3051);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3052);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3053);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3054);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3055);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3056);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3057);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3058);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3059);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3060);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3061);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3062);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3063);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3064);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3065);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3066);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3067);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3068);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3069);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3070);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3071);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3072);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3073);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3074);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3075);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3076);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3077);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3078);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3079);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3080);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3081);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3082);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3083);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3084);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3085);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3086);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3087);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3088);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3089);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3090);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3091);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3092);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3093);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3094);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3095);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3096);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3097);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3098);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3099);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3100);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3101);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3102);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3103);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3104);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3105);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3106);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3107);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3108);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3109);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3110);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3111);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3112);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3113);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3114);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3115);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3116);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3117);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3118);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3119);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3120);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3121);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3122);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3123);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 3124);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4001);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4002);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4003);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4004);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4005);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4006);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4007);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4008);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4009);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4010);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4011);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4012);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4013);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4014);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4015);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4016);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4017);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4018);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4019);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4020);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4021);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4022);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4023);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4024);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4025);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4026);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4027);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4028);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4029);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4030);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4031);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4032);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4033);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4034);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4035);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4036);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4037);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4038);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4039);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4040);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4041);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4042);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4043);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4044);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4045);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4046);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4047);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4048);

            migrationBuilder.DeleteData(
                table: "Studenti",
                keyColumn: "BrojNaIndeks",
                keyValue: 4049);
        }
    }
}
