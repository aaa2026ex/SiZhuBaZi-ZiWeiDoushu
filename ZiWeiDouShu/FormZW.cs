using tyme.lunar;
using tyme.solar;

namespace ZiWeiDouShu
{
    public partial class FormZW : Form
    {
        //天干地支
        string jia = "甲"; string yii = "乙"; string bing = "丙"; string ding = "丁"; string wuu = "戊";
        string jii = "己"; string geng = "庚"; string xin = "辛"; string ren = "壬"; string gui = "癸";
        string zii = "子"; string chou = "丑"; string yin = "寅"; string mao = "卯"; string chen = "辰"; string sii = "巳";
        string wuma = "午"; string wei = "未"; string shen = "申"; string you = "酉"; string xuu = "戌"; string hai = "亥";

        //四柱
        string ntg = "";
        string ytg = "";
        string rtg = "";
        string stg = "";
        string ndz = "";
        string ydz = "";
        string rdz = "";
        string sdz = "";
        //五虎遁查干
        string tiangan = ""; string dizhi = "";
        //命宫干支
        string minggongganzhi = "";
        //纳音五行
        int wuxingguilein = 0;//一金二水三木四火五土
        //命宫位
        int dayunyin = 0; int dayunmao = 0; int dayunchen = 0; int dayunsi = 0;
        int dayunwu = 0; int dayunwei = 0; int dayunshen = 0; int dayunyou = 0;
        int dayunxu = 0; int dayunhai = 0; int dayunzi = 0; int dayunchou = 0; int shinianshuzi = 0;
        //身宫
        int shengongyin = 0; int shengongmao = 0; int shengongchen = 0; int shengongsi = 0;
        int shengongwu = 0; int shengongwei = 0; int shengongshen = 0; int shengongyou = 0;
        int shengongxu = 0; int shengonghai = 0; int shengongzi = 0; int shengongchou = 0;
        //时间
        int monthNL = 0; int dayNL = 0; int hourNL = 0;
        //紫微星坐标
        int ziweixingzuobiaoyin = 0; int ziweixingzuobiaomao = 0; int ziweixingzuobiaochen = 0; int ziweixingzuobiaosi = 0;
        int ziweixingzuobiaowu = 0; int ziweixingzuobiaowei = 0; int ziweixingzuobiaoshen = 0; int ziweixingzuobiaoyou = 0;
        int ziweixingzuobiaoxu = 0; int ziweixingzuobiaohai = 0; int ziweixingzuobiaozi = 0; int ziweixingzuobiaochou = 0;
        //甲子六旬空亡
        int jiazi = 0; int jiaxu = 0; int jiashen = 0; int jiawu = 0; int jiachen = 0; int jiayin = 0;
        //十二长生大运
        string dyss10 = ""; string dyss20 = ""; string dyss30 = ""; string dyss40 = ""; string dyss50 = ""; string dyss60 = "";
        string dyss70 = ""; string dyss80 = ""; string dyss90 = ""; string dyss100 = ""; string dyss110 = ""; string dyss120 = "";
        string dy10 = ""; string dy20 = ""; string dy30 = ""; string dy40 = ""; string dy50 = ""; string dy60 = "";
        string dy70 = ""; string dy80 = ""; string dy90 = ""; string dy100 = ""; string dy110 = ""; string dy120 = "";
        string shierchengsheng1 = ""; string shierchengsheng2 = ""; string shierchengsheng3 = ""; string shierchengsheng4 = ""; string shierchengsheng5 = ""; string shierchengsheng6 = "";
        string shierchengsheng7 = ""; string shierchengsheng8 = ""; string shierchengsheng9 = ""; string shierchengsheng10 = ""; string shierchengsheng11 = ""; string shierchengsheng12 = "";
        string changsheng = "长生"; string muyu = "沐浴"; string guandai = "冠带"; string linguan = "临官"; string diwang = "帝旺"; string shuai = "衰";
        string bingg = "病"; string ssii = "死"; string mmuu = "墓"; string jue = "绝"; string tai = "胎"; string yang = "养";

        public FormZW()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化计时器
            timer1.Enabled = true; timer1.Interval = 1000;
            //获取时间
            numericUpDownyear.Value = DateTime.Now.Year;
            numericUpDownmonth.Value = DateTime.Now.Month;
            numericUpDownday.Value = DateTime.Now.Day;
            numericUpDownhour.Value = DateTime.Now.Hour;
            //排盘
            ShiJianPaipan_Click(this, new EventArgs());


        } //主窗口
        private void ZiWeiPaiPan_Click(object sender, EventArgs e)
        {
            //排八字
            if (jia == jia)
            {
                labelng.Text = ntg;
                labelnz.Text = ndz;
                labelyg.Text = ytg;
                labelyz.Text = ydz;
                labelrg.Text = rtg;
                labelrz.Text = rdz;
                labelsg.Text = stg;
                labelsz.Text = sdz;
            }
            //八字干支色彩
            if (jia == jia)
            {
                if (ntg == jia || ntg == yii)
                {
                    labelng.ForeColor = Color.Green; labelng.BackColor = Color.White;
                }
                if (ntg == bing || ntg == ding)
                {
                    labelng.ForeColor = Color.Red; labelng.BackColor = Color.White;
                }
                if (ntg == wuu || ntg == jii)
                {
                    labelng.ForeColor = Color.Sienna; labelng.BackColor = Color.White;
                }
                if (ntg == geng || ntg == xin)
                {
                    labelng.ForeColor = Color.Gold; labelng.BackColor = Color.Black;
                }
                if (ntg == ren || ntg == gui)
                {
                    labelng.ForeColor = Color.DodgerBlue; labelng.BackColor = Color.White;
                }
                if (ytg == jia || ytg == yii)
                {
                    labelyg.ForeColor = Color.Green; labelyg.BackColor = Color.White;
                }
                if (ytg == bing || ytg == ding)
                {
                    labelyg.ForeColor = Color.Red; labelyg.BackColor = Color.White;
                }
                if (ytg == wuu || ytg == jii)
                {
                    labelyg.ForeColor = Color.Sienna; labelyg.BackColor = Color.White;
                }
                if (ytg == geng || ytg == xin)
                {
                    labelyg.ForeColor = Color.Gold; labelyg.BackColor = Color.Black;
                }
                if (ytg == ren || ytg == gui)
                {
                    labelyg.ForeColor = Color.DodgerBlue; labelyg.BackColor = Color.White;
                }
                if (rtg == jia || rtg == yii)
                {
                    labelrg.ForeColor = Color.Green; labelrg.BackColor = Color.White;
                }
                if (rtg == bing || rtg == ding)
                {
                    labelrg.ForeColor = Color.Red; labelrg.BackColor = Color.White;
                }
                if (rtg == wuu || rtg == jii)
                {
                    labelrg.ForeColor = Color.Sienna; labelrg.BackColor = Color.White;
                }
                if (rtg == geng || rtg == xin)
                {
                    labelrg.ForeColor = Color.Gold; labelrg.BackColor = Color.Black;
                }
                if (rtg == ren || rtg == gui)
                {
                    labelrg.ForeColor = Color.DodgerBlue; labelrg.BackColor = Color.White;
                }
                if (stg == jia || stg == yii)
                {
                    labelsg.ForeColor = Color.Green; labelsg.BackColor = Color.White;
                }
                if (stg == bing || stg == ding)
                {
                    labelsg.ForeColor = Color.Red; labelsg.BackColor = Color.White;
                }
                if (stg == wuu || stg == jii)
                {
                    labelsg.ForeColor = Color.Sienna; labelsg.BackColor = Color.White;
                }
                if (stg == geng || stg == xin)
                {
                    labelsg.ForeColor = Color.Gold; labelsg.BackColor = Color.Black;
                }
                if (stg == ren || stg == gui)
                {
                    labelsg.ForeColor = Color.DodgerBlue; labelsg.BackColor = Color.White;
                }
                if (ndz == yin || ndz == mao)
                {
                    labelnz.ForeColor = Color.Green; labelnz.BackColor = Color.White;
                }
                if (ndz == wuma || ndz == sii)
                {
                    labelnz.ForeColor = Color.Red; labelnz.BackColor = Color.White;
                }
                if (ndz == chen || ndz == wei)
                {
                    labelnz.ForeColor = Color.Sienna; labelnz.BackColor = Color.White;
                }
                if (ndz == chou || ndz == xuu)
                {
                    labelnz.ForeColor = Color.Sienna; labelnz.BackColor = Color.White;
                }
                if (ndz == shen || ndz == you)
                {
                    labelnz.ForeColor = Color.Gold; labelnz.BackColor = Color.Black;
                }
                if (ndz == hai || ndz == zii)
                {
                    labelnz.ForeColor = Color.DodgerBlue; labelnz.BackColor = Color.White;
                }
                if (ydz == yin || ydz == mao)
                {
                    labelyz.ForeColor = Color.Green; labelyz.BackColor = Color.White;
                }
                if (ydz == wuma || ydz == sii)
                {
                    labelyz.ForeColor = Color.Red; labelyz.BackColor = Color.White;
                }
                if (ydz == chen || ydz == wei)
                {
                    labelyz.ForeColor = Color.Sienna; labelyz.BackColor = Color.White;
                }
                if (ydz == chou || ydz == xuu)
                {
                    labelyz.ForeColor = Color.Sienna; labelyz.BackColor = Color.White;
                }
                if (ydz == shen || ydz == you)
                {
                    labelyz.ForeColor = Color.Gold; labelyz.BackColor = Color.Black;
                }
                if (ydz == hai || ydz == zii)
                {
                    labelyz.ForeColor = Color.DodgerBlue; labelyz.BackColor = Color.White;
                }
                if (rdz == yin || rdz == mao)
                {
                    labelrz.ForeColor = Color.Green; labelrz.BackColor = Color.White;
                }
                if (rdz == wuma || rdz == sii)
                {
                    labelrz.ForeColor = Color.Red; labelrz.BackColor = Color.White;
                }
                if (rdz == chen || rdz == wei)
                {
                    labelrz.ForeColor = Color.Sienna; labelrz.BackColor = Color.White;
                }
                if (rdz == chou || rdz == xuu)
                {
                    labelrz.ForeColor = Color.Sienna; labelrz.BackColor = Color.White;
                }
                if (rdz == shen || rdz == you)
                {
                    labelrz.ForeColor = Color.Gold; labelrz.BackColor = Color.Black;
                }
                if (rdz == hai || rdz == zii)
                {
                    labelrz.ForeColor = Color.DodgerBlue; labelrz.BackColor = Color.White;
                }
                if (sdz == yin || sdz == mao)
                {
                    labelsz.ForeColor = Color.Green; labelsz.BackColor = Color.White;
                }
                if (sdz == wuma || sdz == sii)
                {
                    labelsz.ForeColor = Color.Red; labelsz.BackColor = Color.White;
                }
                if (sdz == chen || sdz == wei)
                {
                    labelsz.ForeColor = Color.Sienna; labelsz.BackColor = Color.White;
                }
                if (sdz == chou || sdz == xuu)
                {
                    labelsz.ForeColor = Color.Sienna; labelsz.BackColor = Color.White;
                }
                if (sdz == shen || sdz == you)
                {
                    labelsz.ForeColor = Color.Gold; labelsz.BackColor = Color.Black;
                }
                if (sdz == hai || sdz == zii)
                {
                    labelsz.ForeColor = Color.DodgerBlue; labelsz.BackColor = Color.White;
                }
            }
            //五虎遁查干
            if (jia == jia)
            {
                dizhi = yin;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxyin.Text = tiangan;
                dizhi = mao;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxmao.Text = tiangan;
                dizhi = chen;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxchen.Text = tiangan;
                dizhi = sii;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxsi.Text = tiangan;
                dizhi = wuma;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxwuma.Text = tiangan;
                dizhi = wei;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxwei.Text = tiangan;
                dizhi = shen;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxshen.Text = tiangan;
                dizhi = you;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxyou.Text = tiangan;
                dizhi = xuu;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxxu.Text = tiangan;
                dizhi = hai;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxhai.Text = tiangan;
                dizhi = zii;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxzi.Text = tiangan;
                dizhi = chou;
                wuhudun_Click(this, new EventArgs());
                tiangan += dizhi;
                groupBoxchou.Text = tiangan;
            }
            //安命宫
            if (jia == jia)
            {
                int yuefen = monthNL;//月份
                int shichen = 0;//时辰
                if (hourNL == 0 || hourNL == 23)
                {
                    shichen = 1;
                }
                if (hourNL == 1 || hourNL == 2)
                {
                    shichen = 2;
                }
                if (hourNL == 3 || hourNL == 4)
                {
                    shichen = 3;
                }
                if (hourNL == 5 || hourNL == 6)
                {
                    shichen = 4;
                }
                if (hourNL == 7 || hourNL == 8)
                {
                    shichen = 5;
                }
                if (hourNL == 9 || hourNL == 10)
                {
                    shichen = 6;
                }
                if (hourNL == 11 || hourNL == 12)
                {
                    shichen = 7;
                }
                if (hourNL == 13 || hourNL == 14)
                {
                    shichen = 8;
                }
                if (hourNL == 15 || hourNL == 16)
                {
                    shichen = 9;
                }
                if (hourNL == 17 || hourNL == 18)
                {
                    shichen = 10;
                }
                if (hourNL == 19 || hourNL == 20)
                {
                    shichen = 11;
                }
                if (hourNL == 21 || hourNL == 22)
                {
                    shichen = 12;
                }

                //逆数寻命宫
                int minggong = yuefen - shichen;
                //缩小范围
                if (minggong < 0)
                {
                    minggong += 12;
                }
                labelshengongyin.Text = "";
                labelshengongmao.Text = "";
                labelshengongchen.Text = "";
                labelshengongsi.Text = "";
                labelshengongwu.Text = "";
                labelshengongwei.Text = "";
                labelshengongshen.Text = "";
                labelshengongyou.Text = "";
                labelshengongxu.Text = "";
                labelshengonghai.Text = "";
                labelshengongzi.Text = "";
                labelshengongchou.Text = "";

                dayunyin = 0; dayunmao = 0; dayunchen = 0; dayunsi = 0;
                dayunwu = 0; dayunwei = 0; dayunshen = 0; dayunyou = 0;
                dayunxu = 0; dayunhai = 0; dayunzi = 0; dayunchou = 0;
                shengongyin = 0; shengongmao = 0; shengongchen = 0; shengongsi = 0;
                shengongwu = 0; shengongwei = 0; shengongshen = 0; shengongyou = 0;
                shengongxu = 0; shengonghai = 0; shengongzi = 0; shengongchou = 0;
                if (minggong == 0)
                {
                    labelyin.Text = "命宫"; minggongganzhi = groupBoxyin.Text; dayunyin = 1;
                    labelmao.Text = "父母";
                    labelchen.Text = "福德";
                    labelsi.Text = "田宅";
                    labelwu.Text = "官䘵";
                    labelwei.Text = "仆役";
                    labelshen.Text = "迁移";
                    labelyou.Text = "疾厄";
                    labelxu.Text = "财帛";
                    labelhai.Text = "子女";
                    labelzi.Text = "夫妻";
                    labelchou.Text = "兄弟";
                    labelshengongxu.Text = "身宫"; shengongxu = 1;
                }
                if (minggong == 1)
                {
                    labelmao.Text = "命宫"; minggongganzhi = groupBoxmao.Text; dayunmao = 1;
                    labelchen.Text = "父母";
                    labelsi.Text = "福德";
                    labelwu.Text = "田宅";
                    labelwei.Text = "官䘵";
                    labelshen.Text = "仆役";
                    labelyou.Text = "迁移";
                    labelxu.Text = "疾厄";
                    labelhai.Text = "财帛";
                    labelzi.Text = "子女";
                    labelchou.Text = "夫妻";
                    labelyin.Text = "兄弟";
                    labelshengonghai.Text = "身宫"; shengonghai = 1;
                }
                if (minggong == 2)
                {
                    labelchen.Text = "命宫"; minggongganzhi = groupBoxchen.Text; dayunchen = 1;
                    labelsi.Text = "父母";
                    labelwu.Text = "福德";
                    labelwei.Text = "田宅";
                    labelshen.Text = "官䘵";
                    labelyou.Text = "仆役";
                    labelxu.Text = "迁移";
                    labelhai.Text = "疾厄";
                    labelzi.Text = "财帛";
                    labelchou.Text = "子女";
                    labelyin.Text = "夫妻";
                    labelmao.Text = "兄弟";
                    labelshengongzi.Text = "身宫"; shengongzi = 1;
                }
                if (minggong == 3)
                {
                    labelsi.Text = "命宫"; minggongganzhi = groupBoxsi.Text; dayunsi = 1;
                    labelwu.Text = "父母";
                    labelwei.Text = "福德";
                    labelshen.Text = "田宅";
                    labelyou.Text = "官䘵";
                    labelxu.Text = "仆役";
                    labelhai.Text = "迁移";
                    labelzi.Text = "疾厄";
                    labelchou.Text = "财帛";
                    labelyin.Text = "子女";
                    labelmao.Text = "夫妻";
                    labelchen.Text = "兄弟";
                    labelshengongchou.Text = "身宫"; shengongchou = 1;
                }
                if (minggong == 4)
                {
                    labelwu.Text = "命宫"; minggongganzhi = groupBoxwuma.Text; dayunwu = 1;
                    labelwei.Text = "父母";
                    labelshen.Text = "福德";
                    labelyou.Text = "田宅";
                    labelxu.Text = "官䘵";
                    labelhai.Text = "仆役";
                    labelzi.Text = "迁移";
                    labelchou.Text = "疾厄";
                    labelyin.Text = "财帛";
                    labelmao.Text = "子女";
                    labelchen.Text = "夫妻";
                    labelsi.Text = "兄弟";
                    labelshengongyin.Text = "身宫"; shengongyin = 1;
                }
                if (minggong == 5)
                {
                    labelwei.Text = "命宫"; minggongganzhi = groupBoxwei.Text; dayunwei = 1;
                    labelshen.Text = "父母";
                    labelyou.Text = "福德";
                    labelxu.Text = "田宅";
                    labelhai.Text = "官䘵";
                    labelzi.Text = "仆役";
                    labelchou.Text = "迁移";
                    labelyin.Text = "疾厄";
                    labelmao.Text = "财帛";
                    labelchen.Text = "子女";
                    labelsi.Text = "夫妻";
                    labelwu.Text = "兄弟";
                    labelshengongmao.Text = "身宫"; shengongmao = 1;
                }
                if (minggong == 6)
                {
                    labelshen.Text = "命宫"; minggongganzhi = groupBoxshen.Text; dayunshen = 1;
                    labelyou.Text = "父母";
                    labelxu.Text = "福德";
                    labelhai.Text = "田宅";
                    labelzi.Text = "官䘵";
                    labelchou.Text = "仆役";
                    labelyin.Text = "迁移";
                    labelmao.Text = "疾厄";
                    labelchen.Text = "财帛";
                    labelsi.Text = "子女";
                    labelwu.Text = "夫妻";
                    labelwei.Text = "兄弟";
                    labelshengongchen.Text = "身宫"; shengongchen = 1;
                }
                if (minggong == 7)
                {
                    labelyou.Text = "命宫"; minggongganzhi = groupBoxyou.Text; dayunyou = 1;
                    labelxu.Text = "父母";
                    labelhai.Text = "福德";
                    labelzi.Text = "田宅";
                    labelchou.Text = "官䘵";
                    labelyin.Text = "仆役";
                    labelmao.Text = "迁移";
                    labelchen.Text = "疾厄";
                    labelsi.Text = "财帛";
                    labelwu.Text = "子女";
                    labelwei.Text = "夫妻";
                    labelshen.Text = "兄弟";
                    labelshengongsi.Text = "身宫"; shengongsi = 1;
                }
                if (minggong == 8)
                {
                    labelxu.Text = "命宫"; minggongganzhi = groupBoxxu.Text; dayunxu = 1;
                    labelhai.Text = "父母";
                    labelzi.Text = "福德";
                    labelchou.Text = "田宅";
                    labelyin.Text = "官䘵";
                    labelmao.Text = "仆役";
                    labelchen.Text = "迁移";
                    labelsi.Text = "疾厄";
                    labelwu.Text = "财帛";
                    labelwei.Text = "子女";
                    labelshen.Text = "夫妻";
                    labelyou.Text = "兄弟";
                    labelshengongwu.Text = "身宫"; shengongwu = 1;
                }
                if (minggong == 9)
                {
                    labelhai.Text = "命宫"; minggongganzhi = groupBoxhai.Text; dayunhai = 1;
                    labelzi.Text = "父母";
                    labelchou.Text = "福德";
                    labelyin.Text = "田宅";
                    labelmao.Text = "官䘵";
                    labelchen.Text = "仆役";
                    labelsi.Text = "迁移";
                    labelwu.Text = "疾厄";
                    labelwei.Text = "财帛";
                    labelshen.Text = "子女";
                    labelyou.Text = "夫妻";
                    labelxu.Text = "兄弟";
                    labelshengongwei.Text = "身宫"; shengongwei = 1;
                }
                if (minggong == 10)
                {
                    labelzi.Text = "命宫"; minggongganzhi = groupBoxzi.Text; dayunzi = 1;
                    labelchou.Text = "父母";
                    labelyin.Text = "福德";
                    labelmao.Text = "田宅";
                    labelchen.Text = "官䘵";
                    labelsi.Text = "仆役";
                    labelwu.Text = "迁移";
                    labelwei.Text = "疾厄";
                    labelshen.Text = "财帛";
                    labelyou.Text = "子女";
                    labelxu.Text = "夫妻";
                    labelhai.Text = "兄弟";
                    labelshengongshen.Text = "身宫"; shengongshen = 1;
                }
                if (minggong == 11)
                {
                    labelchou.Text = "命宫"; minggongganzhi = groupBoxchou.Text; dayunchou = 1;
                    labelyin.Text = "父母";
                    labelmao.Text = "福德";
                    labelchen.Text = "田宅";
                    labelsi.Text = "官䘵";
                    labelwu.Text = "仆役";
                    labelwei.Text = "迁移";
                    labelshen.Text = "疾厄";
                    labelyou.Text = "财帛";
                    labelxu.Text = "子女";
                    labelhai.Text = "夫妻";
                    labelzi.Text = "兄弟";
                    labelshengongyou.Text = "身宫"; shengongyou = 1;
                }

            }
            //纳音
            if (jia == jia)
            {
                //截取命宫干支
                string jieqvgan = minggongganzhi.Substring(0, 1);
                string jieqvzhi = minggongganzhi.Substring(1);
                //金
                if (jieqvgan == jia && jieqvzhi == zii || jieqvgan == yii && jieqvzhi == chou)
                {
                    labelqidayun.Text = "金四局 海中金"; wuxingguilein = 1; shinianshuzi = 4;
                    labelqidayun.BackColor = Color.Black;
                    labelqidayun.ForeColor = Color.Gold;
                }
                if (jieqvgan == jia && jieqvzhi == wuma || jieqvgan == yii && jieqvzhi == wei)
                {
                    labelqidayun.Text = "金四局 沙中金"; wuxingguilein = 1; shinianshuzi = 4;
                    labelqidayun.BackColor = Color.Black;
                    labelqidayun.ForeColor = Color.Gold;
                }
                if (jieqvgan == ren && jieqvzhi == yin || jieqvgan == gui && jieqvzhi == mao)
                {
                    labelqidayun.Text = "金四局 金箔金"; wuxingguilein = 1; shinianshuzi = 4;
                    labelqidayun.BackColor = Color.Black;
                    labelqidayun.ForeColor = Color.Gold;
                }
                if (jieqvgan == ren && jieqvzhi == shen || jieqvgan == gui && jieqvzhi == you)
                {
                    labelqidayun.Text = "金四局 剑锋金"; wuxingguilein = 1; shinianshuzi = 4;
                    labelqidayun.BackColor = Color.Black;
                    labelqidayun.ForeColor = Color.Gold;
                }
                if (jieqvgan == geng && jieqvzhi == chen || jieqvgan == xin && jieqvzhi == sii)
                {
                    labelqidayun.Text = "金四局 白蜡金"; wuxingguilein = 1; shinianshuzi = 4;
                    labelqidayun.BackColor = Color.Black;
                    labelqidayun.ForeColor = Color.Gold;
                }
                if (jieqvgan == geng && jieqvzhi == xuu || jieqvgan == xin && jieqvzhi == hai)
                {
                    labelqidayun.Text = "金四局 钗钏金"; wuxingguilein = 1; shinianshuzi = 4;
                    labelqidayun.BackColor = Color.Black;
                    labelqidayun.ForeColor = Color.Gold;
                }
                //木
                if (jieqvgan == ren && jieqvzhi == zii || jieqvgan == gui && jieqvzhi == chou)
                {
                    labelqidayun.Text = "木三局 桑拓木"; wuxingguilein = 3; shinianshuzi = 3;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Green;
                }
                if (jieqvgan == ren && jieqvzhi == wuma || jieqvgan == gui && jieqvzhi == wei)
                {
                    labelqidayun.Text = "木三局 杨柳木"; wuxingguilein = 3; shinianshuzi = 3;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Green;
                }
                if (jieqvgan == geng && jieqvzhi == yin || jieqvgan == xin && jieqvzhi == mao)
                {
                    labelqidayun.Text = "木三局 松柏木"; wuxingguilein = 3; shinianshuzi = 3;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Green;
                }
                if (jieqvgan == geng && jieqvzhi == shen || jieqvgan == xin && jieqvzhi == you)
                {
                    labelqidayun.Text = "木三局 石榴木"; wuxingguilein = 3; shinianshuzi = 3;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Green;
                }
                if (jieqvgan == wuu && jieqvzhi == chen || jieqvgan == jii && jieqvzhi == sii)
                {
                    labelqidayun.Text = "木三局 大林木"; wuxingguilein = 3; shinianshuzi = 3;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Green;
                }
                if (jieqvgan == wuu && jieqvzhi == xuu || jieqvgan == jii && jieqvzhi == hai)
                {
                    labelqidayun.Text = "木三局 平地木"; wuxingguilein = 3; shinianshuzi = 3;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Green;
                }
                //土
                if (jieqvgan == geng && jieqvzhi == zii || jieqvgan == xin && jieqvzhi == chou)
                {
                    labelqidayun.Text = "土五局 壁上土"; wuxingguilein = 5; shinianshuzi = 5;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Sienna;
                }
                if (jieqvgan == geng && jieqvzhi == wuma || jieqvgan == xin && jieqvzhi == wei)
                {
                    labelqidayun.Text = "土五局 路旁土"; wuxingguilein = 5; shinianshuzi = 5;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Sienna;
                }
                if (jieqvgan == wuu && jieqvzhi == yin || jieqvgan == jii && jieqvzhi == mao)
                {
                    labelqidayun.Text = "土五局 城头土"; wuxingguilein = 5; shinianshuzi = 5;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Sienna;
                }
                if (jieqvgan == wuu && jieqvzhi == shen || jieqvgan == jii && jieqvzhi == you)
                {
                    labelqidayun.Text = "土五局 大驿土"; wuxingguilein = 5; shinianshuzi = 5;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Sienna;
                }
                if (jieqvgan == bing && jieqvzhi == chen || jieqvgan == ding && jieqvzhi == sii)
                {
                    labelqidayun.Text = "土五局 沙中土"; wuxingguilein = 5; shinianshuzi = 5;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Sienna;
                }
                if (jieqvgan == bing && jieqvzhi == xuu || jieqvgan == ding && jieqvzhi == hai)
                {
                    labelqidayun.Text = "土五局 屋上土"; wuxingguilein = 5; shinianshuzi = 5;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Sienna;
                }
                //水
                if (jieqvgan == bing && jieqvzhi == zii || jieqvgan == ding && jieqvzhi == chou)
                {
                    labelqidayun.Text = "水二局 涧下水"; wuxingguilein = 2; shinianshuzi = 2;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.DodgerBlue;
                }
                if (jieqvgan == bing && jieqvzhi == wuma || jieqvgan == ding && jieqvzhi == wei)
                {
                    labelqidayun.Text = "水二局 天河水"; wuxingguilein = 2; shinianshuzi = 2;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.DodgerBlue;
                }
                if (jieqvgan == jia && jieqvzhi == yin || jieqvgan == yii && jieqvzhi == mao)
                {
                    labelqidayun.Text = "水二局 大溪水"; wuxingguilein = 2; shinianshuzi = 2;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.DodgerBlue;
                }
                if (jieqvgan == jia && jieqvzhi == shen || jieqvgan == yii && jieqvzhi == you)
                {
                    labelqidayun.Text = "水二局 井泉水"; wuxingguilein = 2; shinianshuzi = 2;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.DodgerBlue;
                }
                if (jieqvgan == ren && jieqvzhi == chen || jieqvgan == gui && jieqvzhi == sii)
                {
                    labelqidayun.Text = "水二局 长流水"; wuxingguilein = 2; shinianshuzi = 2;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.DodgerBlue;
                }
                if (jieqvgan == ren && jieqvzhi == xuu || jieqvgan == gui && jieqvzhi == hai)
                {
                    labelqidayun.Text = "水二局 大海水"; wuxingguilein = 2; shinianshuzi = 2;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.DodgerBlue;
                }
                //火
                if (jieqvgan == wuu && jieqvzhi == zii || jieqvgan == jii && jieqvzhi == chou)
                {
                    labelqidayun.Text = "火六局 霹雳火"; wuxingguilein = 4; shinianshuzi = 6;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Red;
                }
                if (jieqvgan == wuu && jieqvzhi == wuma || jieqvgan == jii && jieqvzhi == wei)
                {
                    labelqidayun.Text = "火六局 天上火"; wuxingguilein = 4; shinianshuzi = 6;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Red;
                }
                if (jieqvgan == bing && jieqvzhi == yin || jieqvgan == ding && jieqvzhi == mao)
                {
                    labelqidayun.Text = "火六局 炉中火"; wuxingguilein = 4; shinianshuzi = 6;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Red;
                }
                if (jieqvgan == bing && jieqvzhi == shen || jieqvgan == ding && jieqvzhi == you)
                {
                    labelqidayun.Text = "火六局 山下火"; wuxingguilein = 4; shinianshuzi = 6;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Red;
                }
                if (jieqvgan == jia && jieqvzhi == chen || jieqvgan == yii && jieqvzhi == sii)
                {
                    labelqidayun.Text = "火六局 覆灯火"; wuxingguilein = 4; shinianshuzi = 6;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Red;
                }
                if (jieqvgan == jia && jieqvzhi == xuu || jieqvgan == yii && jieqvzhi == hai)
                {
                    labelqidayun.Text = "火六局 山头火"; wuxingguilein = 4; shinianshuzi = 6;
                    labelqidayun.BackColor = Color.White;
                    labelqidayun.ForeColor = Color.Red;
                }

            }
            //空亡
            if (jia == jia)
            {
                labelkongwangyin.Text = "";
                labelkongwangmao.Text = "";
                labelkongwangchen.Text = "";
                labelkongwangsi.Text = "";
                labelkongwangwu.Text = "";
                labelkongwangwei.Text = "";
                labelkongwangshen.Text = "";
                labelkongwangyou.Text = "";
                labelkongwangxu.Text = "";
                labelkongwanghai.Text = "";
                labelkongwangzi.Text = "";
                labelkongwangchou.Text = "";
                jiazi = 0; jiaxu = 0; jiashen = 0; jiawu = 0; jiachen = 0; jiayin = 0;

                if (ntg == jia && ndz == zii)
                {
                    jiazi = 1;
                }
                if (ntg == yii && ndz == chou)
                {
                    jiazi = 1;
                }
                if (ntg == bing && ndz == yin)
                {
                    jiazi = 1;
                }
                if (ntg == ding && ndz == mao)
                {
                    jiazi = 1;
                }
                if (ntg == wuu && ndz == chen)
                {
                    jiazi = 1;
                }
                if (ntg == jii && ndz == sii)
                {
                    jiazi = 1;
                }
                if (ntg == geng && ndz == wuma)
                {
                    jiazi = 1;
                }
                if (ntg == xin && ndz == wei)
                {
                    jiazi = 1;
                }
                if (ntg == ren && ndz == shen)
                {
                    jiazi = 1;
                }
                if (ntg == gui && ndz == you)
                {
                    jiazi = 1;
                }

                if (ntg == jia && ndz == xuu)
                {
                    jiaxu = 1;
                }
                if (ntg == yii && ndz == hai)
                {
                    jiaxu = 1;
                }
                if (ntg == bing && ndz == zii)
                {
                    jiaxu = 1;
                }
                if (ntg == ding && ndz == chou)
                {
                    jiaxu = 1;
                }
                if (ntg == wuu && ndz == yin)
                {
                    jiaxu = 1;
                }
                if (ntg == jii && ndz == mao)
                {
                    jiaxu = 1;
                }
                if (ntg == geng && ndz == chen)
                {
                    jiaxu = 1;
                }
                if (ntg == xin && ndz == sii)
                {
                    jiaxu = 1;
                }
                if (ntg == ren && ndz == wuma)
                {
                    jiaxu = 1;
                }
                if (ntg == gui && ndz == wei)
                {
                    jiaxu = 1;
                }

                if (ntg == jia && ndz == shen)
                {
                    jiashen = 1;
                }
                if (ntg == yii && ndz == you)
                {
                    jiashen = 1;
                }
                if (ntg == bing && ndz == xuu)
                {
                    jiashen = 1;
                }
                if (ntg == ding && ndz == hai)
                {
                    jiashen = 1;
                }
                if (ntg == wuu && ndz == zii)
                {
                    jiashen = 1;
                }
                if (ntg == jii && ndz == chou)
                {
                    jiashen = 1;
                }
                if (ntg == geng && ndz == yin)
                {
                    jiashen = 1;
                }
                if (ntg == xin && ndz == mao)
                {
                    jiashen = 1;
                }
                if (ntg == ren && ndz == chen)
                {
                    jiashen = 1;
                }
                if (ntg == gui && ndz == sii)
                {
                    jiashen = 1;
                }
                if (ntg == jia && ndz == wuma)
                {
                    jiawu = 1;
                }
                if (ntg == yii && ndz == wei)
                {
                    jiawu = 1;
                }
                if (ntg == bing && ndz == shen)
                {
                    jiawu = 1;
                }
                if (ntg == ding && ndz == you)
                {
                    jiawu = 1;
                }
                if (ntg == wuu && ndz == xuu)
                {
                    jiawu = 1;
                }
                if (ntg == jii && ndz == hai)
                {
                    jiawu = 1;
                }
                if (ntg == geng && ndz == zii)
                {
                    jiawu = 1;
                }
                if (ntg == xin && ndz == chou)
                {
                    jiawu = 1;
                }
                if (ntg == ren && ndz == yin)
                {
                    jiawu = 1;
                }
                if (ntg == gui && ndz == mao)
                {
                    jiawu = 1;
                }
                if (ntg == jia && ndz == chen)
                {
                    jiachen = 1;
                }
                if (ntg == yii && ndz == sii)
                {
                    jiachen = 1;
                }
                if (ntg == bing && ndz == wuma)
                {
                    jiachen = 1;
                }
                if (ntg == ding && ndz == wei)
                {
                    jiachen = 1;
                }
                if (ntg == wuu && ndz == shen)
                {
                    jiachen = 1;
                }
                if (ntg == jii && ndz == you)
                {
                    jiachen = 1;
                }
                if (ntg == geng && ndz == xuu)
                {
                    jiachen = 1;
                }
                if (ntg == xin && ndz == hai)
                {
                    jiachen = 1;
                }
                if (ntg == ren && ndz == zii)
                {
                    jiachen = 1;
                }
                if (ntg == gui && ndz == chou)
                {
                    jiachen = 1;
                }
                if (ntg == jia && ndz == yin)
                {
                    jiayin = 1;
                }
                if (ntg == yii && ndz == mao)
                {
                    jiayin = 1;
                }
                if (ntg == bing && ndz == chen)
                {
                    jiayin = 1;
                }
                if (ntg == ding && ndz == sii)
                {
                    jiayin = 1;
                }
                if (ntg == wuu && ndz == wuma)
                {
                    jiayin = 1;
                }
                if (ntg == jii && ndz == wei)
                {
                    jiayin = 1;
                }
                if (ntg == geng && ndz == shen)
                {
                    jiayin = 1;
                }
                if (ntg == xin && ndz == you)
                {
                    jiayin = 1;
                }
                if (ntg == ren && ndz == xuu)
                {
                    jiayin = 1;
                }
                if (ntg == gui && ndz == hai)
                {
                    jiayin = 1;
                }
                if (jiazi == 1)
                {
                    labelkongwangxu.Text = "空亡";
                    labelkongwanghai.Text = "空亡";
                }
                if (jiaxu == 1)
                {
                    labelkongwangshen.Text = "空亡";
                    labelkongwangyou.Text = "空亡";
                }
                if (jiashen == 1)
                {
                    labelkongwangwu.Text = "空亡";
                    labelkongwangwei.Text = "空亡";
                }
                if (jiawu == 1)
                {
                    labelkongwangchen.Text = "空亡";
                    labelkongwangsi.Text = "空亡";
                }
                if (jiachen == 1)
                {
                    labelkongwangyin.Text = "空亡";
                    labelkongwangmao.Text = "空亡";
                }
                if (jiayin == 1)
                {
                    labelkongwangzi.Text = "空亡";
                    labelkongwangchou.Text = "空亡";
                }

            }
            //起大运年宫位
            if (jia == jia)
            {
                if (radioButtonll.Checked)
                {
                    if (ntg == jia || ntg == wuu || ntg == ren || ntg == bing || ntg == geng)
                    {
                        if (dayunyin == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyin.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunmao == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxmao.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunsi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxsi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwuma.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwei == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwei.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunshen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxshen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunyou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunxu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxxu.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunhai == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxhai.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunzi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxzi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                        }

                    }
                    if (ntg == yii || ntg == jii || ntg == gui || ntg == ding || ntg == xin)
                    {
                        if (dayunyin == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyin.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunzi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxzi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunhai == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxhai.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunxu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxxu.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunyou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunshen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxshen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwei == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwei.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwuma.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunsi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxsi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunmao == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxmao.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                        }

                    }
                }
                if (radioButtonvv.Checked)
                {
                    if (ntg == jia || ntg == wuu || ntg == ren || ntg == bing || ntg == geng)
                    {
                        if (dayunyin == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyin.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunzi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxzi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunhai == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxhai.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunxu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxxu.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunyou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunshen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxshen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwei == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwei.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwuma.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunsi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxsi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunmao == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxmao.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                        }

                    }
                    if (ntg == yii || ntg == jii || ntg == gui || ntg == ding || ntg == xin)
                    {
                        if (dayunyin == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyin.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunmao == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxmao.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunsi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxsi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwuma.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunwei == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxwei.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunshen == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxshen.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunyou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxyou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunxu == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxxu.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunhai == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxhai.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunzi == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxzi.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxchou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                        }
                        if (dayunchou == 1)
                        {
                            int jiashang = 10 + shinianshuzi;
                            groupBoxchou.Text += " - " + shinianshuzi + " - " + jiashang;
                            int jiashang2 = 10 + jiashang;
                            groupBoxyin.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxmao.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxchen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxsi.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwuma.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxwei.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxshen.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxyou.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxxu.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxhai.Text += " - " + jiashang + " - " + jiashang2;
                            jiashang += 10; jiashang2 += 10;
                            groupBoxzi.Text += " - " + jiashang + " - " + jiashang2;
                        }

                    }
                }
            }
            //安紫微星//文昌文曲//恩光天贵//左辅右弼//三台八座
            if (jia == jia)
            {
                if (ntg == jia)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机黑";
                        labelziweihai.Text = "太阳忌黑";
                        labelziweixu.Text = "武曲科辉";
                        labelziweiyou.Text = "天同昏";
                        labelziweiwu.Text = "廉贞禄昏";

                        labeltianfumao.Text = "太阴黑";
                        labeltianfuchen.Text = "贪狼辉";
                        labeltianfusi.Text = "巨门耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军权辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机亮";
                        labelziweizi.Text = "太阳忌黑";
                        labelziweihai.Text = "武曲科昏";
                        labelziweixu.Text = "天同昏";
                        labelziweiwei.Text = "廉贞禄明";

                        labeltianfuyin.Text = "太阴耀";
                        labeltianfumao.Text = "贪狼明";
                        labeltianfuchen.Text = "巨门黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军权昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机耀";
                        labelziweichou.Text = "太阳忌暗";
                        labelziweizi.Text = "武曲科耀";
                        labelziweihai.Text = "天同辉";
                        labelziweishen.Text = "廉贞禄辉";

                        labeltianfuchou.Text = "太阴辉";
                        labeltianfuyin.Text = "贪狼昏";
                        labeltianfumao.Text = "巨门辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军权耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机明";
                        labelziweiyin.Text = "太阳忌耀";
                        labelziweichou.Text = "武曲科辉";
                        labelziweizi.Text = "天同耀";
                        labelziweiyou.Text = "廉贞禄昏";

                        labeltianfuzi.Text = "太阴辉";
                        labeltianfuchou.Text = "贪狼辉";
                        labeltianfuyin.Text = "巨门辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军权黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机昏";
                        labelziweimao.Text = "太阳忌辉";
                        labelziweiyin.Text = "武曲科亮";
                        labelziweichou.Text = "天同暗";
                        labelziweixu.Text = "廉贞禄昏";

                        labeltianfuhai.Text = "太阴辉";
                        labeltianfuzi.Text = "贪狼耀";
                        labeltianfuchou.Text = "巨门暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军权亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机辉";
                        labelziweichen.Text = "太阳忌耀";
                        labelziweimao.Text = "武曲科明";
                        labelziweiyin.Text = "天同明";
                        labelziweihai.Text = "廉贞禄黑";

                        labeltianfuxu.Text = "太阴耀";
                        labeltianfuhai.Text = "贪狼黑";
                        labeltianfuzi.Text = "巨门耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军权耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机黑";
                        labelziweisi.Text = "太阳忌耀";
                        labelziweichen.Text = "武曲科辉";
                        labelziweimao.Text = "天同昏";
                        labelziweizi.Text = "廉贞禄昏";

                        labeltianfuyou.Text = "太阴暗";
                        labeltianfuxu.Text = "贪狼辉";
                        labeltianfuhai.Text = "巨门耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军权耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机亮";
                        labelziweiwu.Text = "太阳忌耀";
                        labelziweisi.Text = "武曲科昏";
                        labelziweichen.Text = "天同昏";
                        labelziweichou.Text = "廉贞禄明";

                        labeltianfushen.Text = "太阴明";
                        labeltianfuyou.Text = "贪狼明";
                        labeltianfuxu.Text = "巨门黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军权昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机耀";
                        labelziweiwei.Text = "太阳忌亮";
                        labelziweiwu.Text = "武曲科耀";
                        labelziweisi.Text = "天同辉";
                        labelziweiyin.Text = "廉贞禄辉";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军权亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机明";
                        labelziweishen.Text = "太阳忌亮";
                        labelziweiwei.Text = "武曲科辉";
                        labelziweiwu.Text = "天同黑";
                        labelziweimao.Text = "廉贞禄昏";

                        labeltianfuwu.Text = "太阴暗";
                        labeltianfuwei.Text = "贪狼辉";
                        labeltianfushen.Text = "巨门辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军权黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机昏";
                        labelziweiyou.Text = "太阳忌黑";
                        labelziweishen.Text = "武曲科亮";
                        labelziweiwei.Text = "天同暗";
                        labelziweichen.Text = "廉贞禄明";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军权亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机辉";
                        labelziweixu.Text = "太阳忌暗";
                        labelziweiyou.Text = "武曲科明";
                        labelziweishen.Text = "天同耀";
                        labelziweisi.Text = "廉贞禄黑";

                        labeltianfuchen.Text = "太阴黑";
                        labeltianfusi.Text = "贪狼黑";
                        labeltianfuwu.Text = "巨门耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军权耀";
                    }
                    //文昌文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == yii)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微科耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微科耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微科亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微科耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微科辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微科辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微科耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微科耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微科亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微科耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微科昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微科辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微科耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微科耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微科亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微科耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微科辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微科辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微科耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微科耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微科亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微科耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微科昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微科辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微科耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微科耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微科亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微科耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微科辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微科辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微科耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微科耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微科亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微科耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微科昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微科辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微科耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微科耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微科亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微科耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微科辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微科辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微科耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微科耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微科亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微科耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微科昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微科辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微科耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微科耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微科亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微科耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微科辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微科辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微科耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微科耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微科亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微科耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微科昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微科辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机禄黑";
                        labelziweihai.Text = "太阳黑";
                        labelziweixu.Text = "武曲辉";
                        labelziweiyou.Text = "天同昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴忌黑";
                        labeltianfuchen.Text = "贪狼辉";
                        labeltianfusi.Text = "巨门耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁权耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机禄亮";
                        labelziweizi.Text = "太阳黑";
                        labelziweihai.Text = "武曲昏";
                        labelziweixu.Text = "天同昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴忌耀";
                        labeltianfumao.Text = "贪狼明";
                        labeltianfuchen.Text = "巨门黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁权辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机禄耀";
                        labelziweichou.Text = "太阳暗";
                        labelziweizi.Text = "武曲耀";
                        labelziweihai.Text = "天同辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴忌辉";
                        labeltianfuyin.Text = "贪狼昏";
                        labeltianfumao.Text = "巨门辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁权黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机禄明";
                        labelziweiyin.Text = "太阳耀";
                        labelziweichou.Text = "武曲辉";
                        labelziweizi.Text = "天同耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴忌辉";
                        labeltianfuchou.Text = "贪狼辉";
                        labeltianfuyin.Text = "巨门辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁权辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机禄昏";
                        labelziweimao.Text = "太阳辉";
                        labelziweiyin.Text = "武曲亮";
                        labelziweichou.Text = "天同暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴忌辉";
                        labeltianfuzi.Text = "贪狼耀";
                        labeltianfuchou.Text = "巨门暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁权辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机禄辉";
                        labelziweichen.Text = "太阳耀";
                        labelziweimao.Text = "武曲明";
                        labelziweiyin.Text = "天同明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴忌耀";
                        labeltianfuhai.Text = "贪狼黑";
                        labeltianfuzi.Text = "巨门耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁权辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机禄黑";
                        labelziweisi.Text = "太阳耀";
                        labelziweichen.Text = "武曲辉";
                        labelziweimao.Text = "天同昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴忌暗";
                        labeltianfuxu.Text = "贪狼辉";
                        labeltianfuhai.Text = "巨门耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁权耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机禄亮";
                        labelziweiwu.Text = "太阳耀";
                        labelziweisi.Text = "武曲昏";
                        labelziweichen.Text = "天同昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴忌明";
                        labeltianfuyou.Text = "贪狼明";
                        labeltianfuxu.Text = "巨门黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁权辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机禄耀";
                        labelziweiwei.Text = "太阳亮";
                        labelziweiwu.Text = "武曲耀";
                        labelziweisi.Text = "天同辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴忌黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁权亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机禄明";
                        labelziweishen.Text = "太阳亮";
                        labelziweiwei.Text = "武曲辉";
                        labelziweiwu.Text = "天同黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴忌暗";
                        labeltianfuwei.Text = "贪狼辉";
                        labeltianfushen.Text = "巨门辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁权辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机禄昏";
                        labelziweiyou.Text = "太阳黑";
                        labelziweishen.Text = "武曲亮";
                        labelziweiwei.Text = "天同暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴忌黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁权亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机禄辉";
                        labelziweixu.Text = "太阳暗";
                        labelziweiyou.Text = "武曲明";
                        labelziweishen.Text = "天同耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴忌黑";
                        labeltianfusi.Text = "贪狼黑";
                        labeltianfuwu.Text = "巨门耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁权黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == bing)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机权黑";
                        labelziweihai.Text = "太阳黑";
                        labelziweixu.Text = "武曲辉";
                        labelziweiyou.Text = "天同禄昏";
                        labelziweiwu.Text = "廉贞忌昏";

                        labeltianfumao.Text = "太阴黑";
                        labeltianfuchen.Text = "贪狼辉";
                        labeltianfusi.Text = "巨门耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机权亮";
                        labelziweizi.Text = "太阳黑";
                        labelziweihai.Text = "武曲昏";
                        labelziweixu.Text = "天同禄昏";
                        labelziweiwei.Text = "廉贞忌明";

                        labeltianfuyin.Text = "太阴耀";
                        labeltianfumao.Text = "贪狼明";
                        labeltianfuchen.Text = "巨门黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机权耀";
                        labelziweichou.Text = "太阳暗";
                        labelziweizi.Text = "武曲耀";
                        labelziweihai.Text = "天同禄辉";
                        labelziweishen.Text = "廉贞忌辉";

                        labeltianfuchou.Text = "太阴辉";
                        labeltianfuyin.Text = "贪狼昏";
                        labeltianfumao.Text = "巨门辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机权明";
                        labelziweiyin.Text = "太阳耀";
                        labelziweichou.Text = "武曲辉";
                        labelziweizi.Text = "天同禄耀";
                        labelziweiyou.Text = "廉贞忌昏";

                        labeltianfuzi.Text = "太阴辉";
                        labeltianfuchou.Text = "贪狼辉";
                        labeltianfuyin.Text = "巨门辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机权昏";
                        labelziweimao.Text = "太阳辉";
                        labelziweiyin.Text = "武曲亮";
                        labelziweichou.Text = "天同禄暗";
                        labelziweixu.Text = "廉贞忌昏";

                        labeltianfuhai.Text = "太阴辉";
                        labeltianfuzi.Text = "贪狼耀";
                        labeltianfuchou.Text = "巨门暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机权辉";
                        labelziweichen.Text = "太阳耀";
                        labelziweimao.Text = "武曲明";
                        labelziweiyin.Text = "天同禄明";
                        labelziweihai.Text = "廉贞忌黑";

                        labeltianfuxu.Text = "太阴耀";
                        labeltianfuhai.Text = "贪狼黑";
                        labeltianfuzi.Text = "巨门耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机权黑";
                        labelziweisi.Text = "太阳耀";
                        labelziweichen.Text = "武曲辉";
                        labelziweimao.Text = "天同禄昏";
                        labelziweizi.Text = "廉贞忌昏";

                        labeltianfuyou.Text = "太阴暗";
                        labeltianfuxu.Text = "贪狼辉";
                        labeltianfuhai.Text = "巨门耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机权亮";
                        labelziweiwu.Text = "太阳耀";
                        labelziweisi.Text = "武曲昏";
                        labelziweichen.Text = "天同禄昏";
                        labelziweichou.Text = "廉贞忌明";

                        labeltianfushen.Text = "太阴明";
                        labeltianfuyou.Text = "贪狼明";
                        labeltianfuxu.Text = "巨门黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机权耀";
                        labelziweiwei.Text = "太阳亮";
                        labelziweiwu.Text = "武曲耀";
                        labelziweisi.Text = "天同禄辉";
                        labelziweiyin.Text = "廉贞忌辉";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机权明";
                        labelziweishen.Text = "太阳亮";
                        labelziweiwei.Text = "武曲辉";
                        labelziweiwu.Text = "天同禄黑";
                        labelziweimao.Text = "廉贞忌昏";

                        labeltianfuwu.Text = "太阴暗";
                        labeltianfuwei.Text = "贪狼辉";
                        labeltianfushen.Text = "巨门辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机权昏";
                        labelziweiyou.Text = "太阳黑";
                        labelziweishen.Text = "武曲亮";
                        labelziweiwei.Text = "天同禄暗";
                        labelziweichen.Text = "廉贞忌明";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机权辉";
                        labelziweixu.Text = "太阳暗";
                        labelziweiyou.Text = "武曲明";
                        labelziweishen.Text = "天同禄耀";
                        labelziweisi.Text = "廉贞忌黑";

                        labeltianfuchen.Text = "太阴黑";
                        labeltianfusi.Text = "贪狼黑";
                        labeltianfuwu.Text = "巨门耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌科文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌科文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌科黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌科辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌科亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌科明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌科黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌科辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌科亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌科明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌科黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌科辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌科亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌科明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == ding)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机科黑";
                        labelziweihai.Text = "太阳黑";
                        labelziweixu.Text = "武曲辉";
                        labelziweiyou.Text = "天同权昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴禄黑";
                        labeltianfuchen.Text = "贪狼辉";
                        labeltianfusi.Text = "巨门忌耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机科亮";
                        labelziweizi.Text = "太阳黑";
                        labelziweihai.Text = "武曲昏";
                        labelziweixu.Text = "天同权昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴禄耀";
                        labeltianfumao.Text = "贪狼明";
                        labeltianfuchen.Text = "巨门忌黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机科耀";
                        labelziweichou.Text = "太阳暗";
                        labelziweizi.Text = "武曲耀";
                        labelziweihai.Text = "天同权辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴禄辉";
                        labeltianfuyin.Text = "贪狼昏";
                        labeltianfumao.Text = "巨门忌辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机科明";
                        labelziweiyin.Text = "太阳耀";
                        labelziweichou.Text = "武曲辉";
                        labelziweizi.Text = "天同权耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴禄辉";
                        labeltianfuchou.Text = "贪狼辉";
                        labeltianfuyin.Text = "巨门忌辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机科昏";
                        labelziweimao.Text = "太阳辉";
                        labelziweiyin.Text = "武曲亮";
                        labelziweichou.Text = "天同权暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴禄辉";
                        labeltianfuzi.Text = "贪狼耀";
                        labeltianfuchou.Text = "巨门忌暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机科辉";
                        labelziweichen.Text = "太阳耀";
                        labelziweimao.Text = "武曲明";
                        labelziweiyin.Text = "天同权明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴禄耀";
                        labeltianfuhai.Text = "贪狼黑";
                        labeltianfuzi.Text = "巨门忌耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机科黑";
                        labelziweisi.Text = "太阳耀";
                        labelziweichen.Text = "武曲辉";
                        labelziweimao.Text = "天同权昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴禄暗";
                        labeltianfuxu.Text = "贪狼辉";
                        labeltianfuhai.Text = "巨门忌耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机科亮";
                        labelziweiwu.Text = "太阳耀";
                        labelziweisi.Text = "武曲昏";
                        labelziweichen.Text = "天同权昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴禄明";
                        labeltianfuyou.Text = "贪狼明";
                        labeltianfuxu.Text = "巨门忌黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机科耀";
                        labelziweiwei.Text = "太阳亮";
                        labelziweiwu.Text = "武曲耀";
                        labelziweisi.Text = "天同权辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴禄黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门忌暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机科明";
                        labelziweishen.Text = "太阳亮";
                        labelziweiwei.Text = "武曲辉";
                        labelziweiwu.Text = "天同权黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴禄暗";
                        labeltianfuwei.Text = "贪狼辉";
                        labeltianfushen.Text = "巨门忌辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机科昏";
                        labelziweiyou.Text = "太阳黑";
                        labelziweishen.Text = "武曲亮";
                        labelziweiwei.Text = "天同权暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴禄黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门忌暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机科辉";
                        labelziweixu.Text = "太阳暗";
                        labelziweiyou.Text = "武曲明";
                        labelziweishen.Text = "天同权耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴禄黑";
                        labeltianfusi.Text = "贪狼黑";
                        labeltianfuwu.Text = "巨门忌耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == wuu)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机忌黑";
                        labelziweihai.Text = "太阳黑";
                        labelziweixu.Text = "武曲辉";
                        labelziweiyou.Text = "天同昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴权黑";
                        labeltianfuchen.Text = "贪狼禄辉";
                        labeltianfusi.Text = "巨门耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机忌亮";
                        labelziweizi.Text = "太阳黑";
                        labelziweihai.Text = "武曲昏";
                        labelziweixu.Text = "天同昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴权耀";
                        labeltianfumao.Text = "贪狼禄明";
                        labeltianfuchen.Text = "巨门黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机忌耀";
                        labelziweichou.Text = "太阳暗";
                        labelziweizi.Text = "武曲耀";
                        labelziweihai.Text = "天同辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴权辉";
                        labeltianfuyin.Text = "贪狼禄昏";
                        labeltianfumao.Text = "巨门辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机忌明";
                        labelziweiyin.Text = "太阳耀";
                        labelziweichou.Text = "武曲辉";
                        labelziweizi.Text = "天同耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴权辉";
                        labeltianfuchou.Text = "贪狼禄辉";
                        labeltianfuyin.Text = "巨门辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机忌昏";
                        labelziweimao.Text = "太阳辉";
                        labelziweiyin.Text = "武曲亮";
                        labelziweichou.Text = "天同暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴权辉";
                        labeltianfuzi.Text = "贪狼禄耀";
                        labeltianfuchou.Text = "巨门暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机忌辉";
                        labelziweichen.Text = "太阳耀";
                        labelziweimao.Text = "武曲明";
                        labelziweiyin.Text = "天同明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴权耀";
                        labeltianfuhai.Text = "贪狼禄黑";
                        labeltianfuzi.Text = "巨门耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机忌黑";
                        labelziweisi.Text = "太阳耀";
                        labelziweichen.Text = "武曲辉";
                        labelziweimao.Text = "天同昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴权暗";
                        labeltianfuxu.Text = "贪狼禄辉";
                        labeltianfuhai.Text = "巨门耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机忌亮";
                        labelziweiwu.Text = "太阳耀";
                        labelziweisi.Text = "武曲昏";
                        labelziweichen.Text = "天同昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴权明";
                        labeltianfuyou.Text = "贪狼禄明";
                        labeltianfuxu.Text = "巨门黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机忌耀";
                        labelziweiwei.Text = "太阳亮";
                        labelziweiwu.Text = "武曲耀";
                        labelziweisi.Text = "天同辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴权黑";
                        labeltianfuwu.Text = "贪狼禄耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机忌明";
                        labelziweishen.Text = "太阳亮";
                        labelziweiwei.Text = "武曲辉";
                        labelziweiwu.Text = "天同黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴权暗";
                        labeltianfuwei.Text = "贪狼禄辉";
                        labeltianfushen.Text = "巨门辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机忌昏";
                        labelziweiyou.Text = "太阳黑";
                        labelziweishen.Text = "武曲亮";
                        labelziweiwei.Text = "天同暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴权黑";
                        labeltianfuwu.Text = "贪狼禄耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机忌辉";
                        labelziweixu.Text = "太阳暗";
                        labelziweiyou.Text = "武曲明";
                        labelziweishen.Text = "天同耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴权黑";
                        labeltianfusi.Text = "贪狼禄黑";
                        labeltianfuwu.Text = "巨门耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼科//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼科"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼科"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼科"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼科"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼科"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼科"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼科"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼科"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼科"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼科"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼科"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼科"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == jii)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机黑";
                        labelziweihai.Text = "太阳黑";
                        labelziweixu.Text = "武曲禄辉";
                        labelziweiyou.Text = "天同昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴黑";
                        labeltianfuchen.Text = "贪狼权辉";
                        labeltianfusi.Text = "巨门耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁科耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机亮";
                        labelziweizi.Text = "太阳黑";
                        labelziweihai.Text = "武曲禄昏";
                        labelziweixu.Text = "天同昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴耀";
                        labeltianfumao.Text = "贪狼权明";
                        labeltianfuchen.Text = "巨门黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁科辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机耀";
                        labelziweichou.Text = "太阳暗";
                        labelziweizi.Text = "武曲禄耀";
                        labelziweihai.Text = "天同辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴辉";
                        labeltianfuyin.Text = "贪狼权昏";
                        labeltianfumao.Text = "巨门辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁科黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机明";
                        labelziweiyin.Text = "太阳耀";
                        labelziweichou.Text = "武曲禄辉";
                        labelziweizi.Text = "天同耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴辉";
                        labeltianfuchou.Text = "贪狼权辉";
                        labeltianfuyin.Text = "巨门辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁科辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机昏";
                        labelziweimao.Text = "太阳辉";
                        labelziweiyin.Text = "武曲禄亮";
                        labelziweichou.Text = "天同暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴辉";
                        labeltianfuzi.Text = "贪狼权耀";
                        labeltianfuchou.Text = "巨门暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁科辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机辉";
                        labelziweichen.Text = "太阳耀";
                        labelziweimao.Text = "武曲禄明";
                        labelziweiyin.Text = "天同明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴耀";
                        labeltianfuhai.Text = "贪狼权黑";
                        labeltianfuzi.Text = "巨门耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁科辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机黑";
                        labelziweisi.Text = "太阳耀";
                        labelziweichen.Text = "武曲禄辉";
                        labelziweimao.Text = "天同昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴暗";
                        labeltianfuxu.Text = "贪狼权辉";
                        labeltianfuhai.Text = "巨门耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁科耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机亮";
                        labelziweiwu.Text = "太阳耀";
                        labelziweisi.Text = "武曲禄昏";
                        labelziweichen.Text = "天同昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴明";
                        labeltianfuyou.Text = "贪狼权明";
                        labeltianfuxu.Text = "巨门黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁科辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机耀";
                        labelziweiwei.Text = "太阳亮";
                        labelziweiwu.Text = "武曲禄耀";
                        labelziweisi.Text = "天同辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼权耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁科亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机明";
                        labelziweishen.Text = "太阳亮";
                        labelziweiwei.Text = "武曲禄辉";
                        labelziweiwu.Text = "天同黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴暗";
                        labeltianfuwei.Text = "贪狼权辉";
                        labeltianfushen.Text = "巨门辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁科辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机昏";
                        labelziweiyou.Text = "太阳黑";
                        labelziweishen.Text = "武曲禄亮";
                        labelziweiwei.Text = "天同暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼权耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁科亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机辉";
                        labelziweixu.Text = "太阳暗";
                        labelziweiyou.Text = "武曲禄明";
                        labelziweishen.Text = "天同耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴黑";
                        labeltianfusi.Text = "贪狼权黑";
                        labeltianfuwu.Text = "巨门耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁科黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌文曲忌//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲忌
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲忌亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲忌辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲忌黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲忌耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲忌亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲忌辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲忌黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲忌耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲忌亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲忌辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲忌昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲忌耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == geng)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机黑";
                        labelziweihai.Text = "太阳禄黑";
                        labelziweixu.Text = "武曲权辉";
                        labelziweiyou.Text = "天同忌昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴科黑";
                        labeltianfuchen.Text = "贪狼辉";
                        labeltianfusi.Text = "巨门耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机亮";
                        labelziweizi.Text = "太阳禄黑";
                        labelziweihai.Text = "武曲权昏";
                        labelziweixu.Text = "天同忌昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴科耀";
                        labeltianfumao.Text = "贪狼明";
                        labeltianfuchen.Text = "巨门黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机耀";
                        labelziweichou.Text = "太阳禄暗";
                        labelziweizi.Text = "武曲权耀";
                        labelziweihai.Text = "天同忌辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴科辉";
                        labeltianfuyin.Text = "贪狼昏";
                        labeltianfumao.Text = "巨门辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机明";
                        labelziweiyin.Text = "太阳禄耀";
                        labelziweichou.Text = "武曲权辉";
                        labelziweizi.Text = "天同忌耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴科辉";
                        labeltianfuchou.Text = "贪狼辉";
                        labeltianfuyin.Text = "巨门辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机昏";
                        labelziweimao.Text = "太阳禄辉";
                        labelziweiyin.Text = "武曲权亮";
                        labelziweichou.Text = "天同忌暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴科辉";
                        labeltianfuzi.Text = "贪狼耀";
                        labeltianfuchou.Text = "巨门暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机辉";
                        labelziweichen.Text = "太阳禄耀";
                        labelziweimao.Text = "武曲权明";
                        labelziweiyin.Text = "天同忌明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴科耀";
                        labeltianfuhai.Text = "贪狼黑";
                        labeltianfuzi.Text = "巨门耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机黑";
                        labelziweisi.Text = "太阳禄耀";
                        labelziweichen.Text = "武曲权辉";
                        labelziweimao.Text = "天同忌昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴科暗";
                        labeltianfuxu.Text = "贪狼辉";
                        labeltianfuhai.Text = "巨门耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机亮";
                        labelziweiwu.Text = "太阳禄耀";
                        labelziweisi.Text = "武曲权昏";
                        labelziweichen.Text = "天同忌昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴科明";
                        labeltianfuyou.Text = "贪狼明";
                        labeltianfuxu.Text = "巨门黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机耀";
                        labelziweiwei.Text = "太阳禄亮";
                        labelziweiwu.Text = "武曲权耀";
                        labelziweisi.Text = "天同忌辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴科黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机明";
                        labelziweishen.Text = "太阳禄亮";
                        labelziweiwei.Text = "武曲权辉";
                        labelziweiwu.Text = "天同忌黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴科暗";
                        labeltianfuwei.Text = "贪狼辉";
                        labeltianfushen.Text = "巨门辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机昏";
                        labelziweiyou.Text = "太阳禄黑";
                        labelziweishen.Text = "武曲权亮";
                        labelziweiwei.Text = "天同忌暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴科黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机辉";
                        labelziweixu.Text = "太阳禄暗";
                        labelziweiyou.Text = "武曲权明";
                        labelziweishen.Text = "天同忌耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴科黑";
                        labeltianfusi.Text = "贪狼黑";
                        labeltianfuwu.Text = "巨门耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == xin)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机黑";
                        labelziweihai.Text = "太阳权黑";
                        labelziweixu.Text = "武曲辉";
                        labelziweiyou.Text = "天同昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴黑";
                        labeltianfuchen.Text = "贪狼辉";
                        labeltianfusi.Text = "巨门禄耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机亮";
                        labelziweizi.Text = "太阳权黑";
                        labelziweihai.Text = "武曲昏";
                        labelziweixu.Text = "天同昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴耀";
                        labeltianfumao.Text = "贪狼明";
                        labeltianfuchen.Text = "巨门禄黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机耀";
                        labelziweichou.Text = "太阳权暗";
                        labelziweizi.Text = "武曲耀";
                        labelziweihai.Text = "天同辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴辉";
                        labeltianfuyin.Text = "贪狼昏";
                        labeltianfumao.Text = "巨门禄辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机明";
                        labelziweiyin.Text = "太阳权耀";
                        labelziweichou.Text = "武曲辉";
                        labelziweizi.Text = "天同耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴辉";
                        labeltianfuchou.Text = "贪狼辉";
                        labeltianfuyin.Text = "巨门禄辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机昏";
                        labelziweimao.Text = "太阳权辉";
                        labelziweiyin.Text = "武曲亮";
                        labelziweichou.Text = "天同暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴辉";
                        labeltianfuzi.Text = "贪狼耀";
                        labeltianfuchou.Text = "巨门禄暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机辉";
                        labelziweichen.Text = "太阳权耀";
                        labelziweimao.Text = "武曲明";
                        labelziweiyin.Text = "天同明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴耀";
                        labeltianfuhai.Text = "贪狼黑";
                        labeltianfuzi.Text = "巨门禄耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机黑";
                        labelziweisi.Text = "太阳权耀";
                        labelziweichen.Text = "武曲辉";
                        labelziweimao.Text = "天同昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴暗";
                        labeltianfuxu.Text = "贪狼辉";
                        labeltianfuhai.Text = "巨门禄耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机亮";
                        labelziweiwu.Text = "太阳权耀";
                        labelziweisi.Text = "武曲昏";
                        labelziweichen.Text = "天同昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴明";
                        labeltianfuyou.Text = "贪狼明";
                        labeltianfuxu.Text = "巨门禄黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机耀";
                        labelziweiwei.Text = "太阳权亮";
                        labelziweiwu.Text = "武曲耀";
                        labelziweisi.Text = "天同辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门禄暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机明";
                        labelziweishen.Text = "太阳权亮";
                        labelziweiwei.Text = "武曲辉";
                        labelziweiwu.Text = "天同黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴暗";
                        labeltianfuwei.Text = "贪狼辉";
                        labeltianfushen.Text = "巨门禄辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机昏";
                        labelziweiyou.Text = "太阳权黑";
                        labelziweishen.Text = "武曲亮";
                        labelziweiwei.Text = "天同暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门禄暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机辉";
                        labelziweixu.Text = "太阳权暗";
                        labelziweiyou.Text = "武曲明";
                        labelziweishen.Text = "天同耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴黑";
                        labeltianfusi.Text = "贪狼黑";
                        labeltianfuwu.Text = "巨门禄耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌忌文曲科//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌忌文曲科
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌忌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲科亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌忌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲科辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌忌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲科黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌忌明"; enguang = 6;
                            labelwenquwei.Text = "文曲科耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌忌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲科亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌忌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲科辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌忌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲科黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌忌明"; enguang = 2;
                            labelwenquhai.Text = "文曲科耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌忌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲科亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌忌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲科辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌忌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲科昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌忌明"; enguang = 10;
                            labelwenqumao.Text = "文曲科耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == ren)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微权耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微权耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微权亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微权耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微权辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微权辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微权耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微权耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微权亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微权耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微权昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微权辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微权耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微权耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微权亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微权耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微权辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微权辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微权耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微权耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微权亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微权耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微权昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微权辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微权耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微权耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微权亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微权耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微权辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微权辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微权耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微权耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微权亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微权耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微权昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微权辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微权耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微权耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微权亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微权耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微权辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微权辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微权耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微权耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微权亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微权耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微权昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微权辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微权耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微权耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微权亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微权耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微权辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微权辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微权耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微权耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微权亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微权耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微权昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微权辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机黑";
                        labelziweihai.Text = "太阳黑";
                        labelziweixu.Text = "武曲忌辉";
                        labelziweiyou.Text = "天同昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴黑";
                        labeltianfuchen.Text = "贪狼辉";
                        labeltianfusi.Text = "巨门耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁禄耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机亮";
                        labelziweizi.Text = "太阳黑";
                        labelziweihai.Text = "武曲忌昏";
                        labelziweixu.Text = "天同昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴耀";
                        labeltianfumao.Text = "贪狼明";
                        labeltianfuchen.Text = "巨门黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁禄辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机耀";
                        labelziweichou.Text = "太阳暗";
                        labelziweizi.Text = "武曲忌耀";
                        labelziweihai.Text = "天同辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴辉";
                        labeltianfuyin.Text = "贪狼昏";
                        labeltianfumao.Text = "巨门辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁禄黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机明";
                        labelziweiyin.Text = "太阳耀";
                        labelziweichou.Text = "武曲忌辉";
                        labelziweizi.Text = "天同耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴辉";
                        labeltianfuchou.Text = "贪狼辉";
                        labeltianfuyin.Text = "巨门辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁禄辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机昏";
                        labelziweimao.Text = "太阳辉";
                        labelziweiyin.Text = "武曲忌亮";
                        labelziweichou.Text = "天同暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴辉";
                        labeltianfuzi.Text = "贪狼耀";
                        labeltianfuchou.Text = "巨门暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁禄辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机辉";
                        labelziweichen.Text = "太阳耀";
                        labelziweimao.Text = "武曲忌明";
                        labelziweiyin.Text = "天同明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴耀";
                        labeltianfuhai.Text = "贪狼黑";
                        labeltianfuzi.Text = "巨门耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁禄辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机黑";
                        labelziweisi.Text = "太阳耀";
                        labelziweichen.Text = "武曲忌辉";
                        labelziweimao.Text = "天同昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴暗";
                        labeltianfuxu.Text = "贪狼辉";
                        labeltianfuhai.Text = "巨门耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁禄耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机亮";
                        labelziweiwu.Text = "太阳耀";
                        labelziweisi.Text = "武曲忌昏";
                        labelziweichen.Text = "天同昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴明";
                        labeltianfuyou.Text = "贪狼明";
                        labeltianfuxu.Text = "巨门黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁禄辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机耀";
                        labelziweiwei.Text = "太阳亮";
                        labelziweiwu.Text = "武曲忌耀";
                        labelziweisi.Text = "天同辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁禄亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机明";
                        labelziweishen.Text = "太阳亮";
                        labelziweiwei.Text = "武曲忌辉";
                        labelziweiwu.Text = "天同黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴暗";
                        labeltianfuwei.Text = "贪狼辉";
                        labeltianfushen.Text = "巨门辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁禄辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机昏";
                        labelziweiyou.Text = "太阳黑";
                        labelziweishen.Text = "武曲忌亮";
                        labelziweiwei.Text = "天同暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴黑";
                        labeltianfuwu.Text = "贪狼耀";
                        labeltianfuwei.Text = "巨门暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁禄亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机辉";
                        labelziweixu.Text = "太阳暗";
                        labelziweiyou.Text = "武曲忌明";
                        labelziweishen.Text = "天同耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴黑";
                        labeltianfusi.Text = "贪狼黑";
                        labeltianfuwu.Text = "巨门耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁禄黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军耀";
                    }
                    //文昌文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅科右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅科"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅科"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅科"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅科"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅科"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅科"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅科"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅科"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅科"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅科"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅科"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅科"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
                if (ntg == gui)
                {
                    labelziweiyin.Text = "";
                    labeltianfuyin.Text = "";
                    labelziweimao.Text = "";
                    labeltianfuchou.Text = "";
                    labelziweichen.Text = "";
                    labeltianfuzi.Text = "";
                    labelziweisi.Text = "";
                    labeltianfuhai.Text = "";
                    labelziweiwu.Text = "";
                    labeltianfuxu.Text = "";
                    labelziweiwei.Text = "";
                    labeltianfuyou.Text = "";
                    labelziweishen.Text = "";
                    labeltianfushen.Text = "";
                    labelziweiyou.Text = "";
                    labeltianfuwei.Text = "";
                    labelziweixu.Text = "";
                    labeltianfuwu.Text = "";
                    labelziweihai.Text = "";
                    labeltianfusi.Text = "";
                    labelziweizi.Text = "";
                    labeltianfuchen.Text = "";
                    labelziweichou.Text = "";
                    labeltianfumao.Text = "";
                    ziweixingzuobiaoyin = 0; ziweixingzuobiaomao = 0; ziweixingzuobiaochen = 0; ziweixingzuobiaosi = 0;
                    ziweixingzuobiaowu = 0; ziweixingzuobiaowei = 0; ziweixingzuobiaoshen = 0; ziweixingzuobiaoyou = 0;
                    ziweixingzuobiaoxu = 0; ziweixingzuobiaohai = 0; ziweixingzuobiaozi = 0; ziweixingzuobiaochou = 0;
                    if (wuxingguilein == 1)
                    {
                        if (dayNL == 4 || dayNL == 7 || dayNL == 13)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 11 || dayNL == 17)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 12 || dayNL == 15 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 16 || dayNL == 19 || dayNL == 25)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 20 || dayNL == 23 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 14 || dayNL == 24 || dayNL == 27)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 18 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 22)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 1 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 5)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 9)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 2)
                    {
                        if (dayNL == 2 || dayNL == 3 || dayNL == 26 || dayNL == 27)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 5 || dayNL == 28 || dayNL == 29)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 7 || dayNL == 30)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 9)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 10 || dayNL == 11)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 13)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 15)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 17)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 18 || dayNL == 19)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 20 || dayNL == 21)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 22 || dayNL == 23)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 24 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 3)
                    {
                        if (dayNL == 5 || dayNL == 3)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 8)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 1 || dayNL == 9 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12 || dayNL == 14)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 7 || dayNL == 15 || dayNL == 17)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 18 || dayNL == 20)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 13 || dayNL == 21 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 24 || dayNL == 26)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 19 || dayNL == 27 || dayNL == 29)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 22 || dayNL == 30)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 25)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 2 || dayNL == 28)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 4)
                    {
                        if (dayNL == 6 || dayNL == 11 || dayNL == 21)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 12 || dayNL == 17 || dayNL == 27)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 18 || dayNL == 23)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 24 || dayNL == 29)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 2 || dayNL == 16 || dayNL == 30)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 22)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 14 || dayNL == 28)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 20)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 7 || dayNL == 26)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 3 || dayNL == 13)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 9 || dayNL == 19)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 5 || dayNL == 15 || dayNL == 25)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    if (wuxingguilein == 5)
                    {
                        if (dayNL == 5 || dayNL == 9 || dayNL == 17)
                        {
                            labelziweiyin.Text = "紫微耀"; ziweixingzuobiaoyin = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 10 || dayNL == 14 || dayNL == 22)
                        {
                            labelziweimao.Text = "紫微耀"; ziweixingzuobiaomao = 1;
                            labeltianfuyin.Text = "天府辉";
                        }
                        if (dayNL == 3 || dayNL == 15 || dayNL == 19 || dayNL == 27)
                        {
                            labelziweichen.Text = "紫微亮"; ziweixingzuobiaochen = 1;
                            labeltianfuzi.Text = "天府辉";
                        }
                        if (dayNL == 8 || dayNL == 20 || dayNL == 24)
                        {
                            labelziweisi.Text = "紫微耀"; ziweixingzuobiaosi = 1;
                            labeltianfuhai.Text = "天府亮";
                        }
                        if (dayNL == 1 || dayNL == 13 || dayNL == 25 || dayNL == 29)
                        {
                            labelziweiwu.Text = "紫微辉"; ziweixingzuobiaowu = 1;
                            labeltianfuxu.Text = "天府辉";
                        }
                        if (dayNL == 6 || dayNL == 18 || dayNL == 30)
                        {
                            labelziweiwei.Text = "紫微辉"; ziweixingzuobiaowei = 1;
                            labeltianfuyou.Text = "天府耀";
                        }
                        if (dayNL == 11 || dayNL == 23)
                        {
                            labelziweishen.Text = "紫微耀"; ziweixingzuobiaoshen = 1;
                            labeltianfushen.Text = "天府亮";
                        }
                        if (dayNL == 16 || dayNL == 28)
                        {
                            labelziweiyou.Text = "紫微耀"; ziweixingzuobiaoyou = 1;
                            labeltianfuwei.Text = "天府辉";
                        }
                        if (dayNL == 21)
                        {
                            labelziweixu.Text = "紫微亮"; ziweixingzuobiaoxu = 1;
                            labeltianfuwu.Text = "天府耀";
                        }
                        if (dayNL == 2 || dayNL == 26)
                        {
                            labelziweihai.Text = "紫微耀"; ziweixingzuobiaohai = 1;
                            labeltianfusi.Text = "天府亮";
                        }
                        if (dayNL == 7)
                        {
                            labelziweizi.Text = "紫微昏"; ziweixingzuobiaozi = 1;
                            labeltianfuchen.Text = "天府辉";
                        }
                        if (dayNL == 4 || dayNL == 12)
                        {
                            labelziweichou.Text = "紫微辉"; ziweixingzuobiaochou = 1;
                            labeltianfumao.Text = "天府亮";
                        }
                    }
                    //安十二星
                    if (ziweixingzuobiaoyin == 1)
                    {
                        labelziweichou.Text = "天机黑";
                        labelziweihai.Text = "太阳黑";
                        labelziweixu.Text = "武曲辉";
                        labelziweiyou.Text = "天同昏";
                        labelziweiwu.Text = "廉贞昏";

                        labeltianfumao.Text = "太阴科黑";
                        labeltianfuchen.Text = "贪狼忌辉";
                        labeltianfusi.Text = "巨门权耀";
                        labeltianfuwu.Text = "天相辉";
                        labeltianfuwei.Text = "天梁耀";
                        labeltianfushen.Text = "七杀辉";
                        labeltianfuzi.Text = "破军禄辉";
                    }
                    if (ziweixingzuobiaomao == 1)
                    {
                        labelziweiyin.Text = "天机亮";
                        labelziweizi.Text = "太阳黑";
                        labelziweihai.Text = "武曲昏";
                        labelziweixu.Text = "天同昏";
                        labelziweiwei.Text = "廉贞明";

                        labeltianfuyin.Text = "太阴科耀";
                        labeltianfumao.Text = "贪狼忌明";
                        labeltianfuchen.Text = "巨门权黑";
                        labeltianfusi.Text = "天相亮";
                        labeltianfuwu.Text = "天梁辉";
                        labeltianfuwei.Text = "七杀辉";
                        labeltianfuhai.Text = "破军禄昏";
                    }
                    if (ziweixingzuobiaochen == 1)
                    {
                        labelziweimao.Text = "天机耀";
                        labelziweichou.Text = "太阳暗";
                        labelziweizi.Text = "武曲耀";
                        labelziweihai.Text = "天同辉";
                        labelziweishen.Text = "廉贞辉";

                        labeltianfuchou.Text = "太阴科辉";
                        labeltianfuyin.Text = "贪狼忌昏";
                        labeltianfumao.Text = "巨门权辉";
                        labeltianfuchen.Text = "天相亮";
                        labeltianfusi.Text = "天梁黑";
                        labeltianfuwu.Text = "七杀耀";
                        labeltianfuxu.Text = "破军禄耀";
                    }
                    if (ziweixingzuobiaosi == 1)
                    {
                        labelziweichen.Text = "天机明";
                        labelziweiyin.Text = "太阳耀";
                        labelziweichou.Text = "武曲辉";
                        labelziweizi.Text = "天同耀";
                        labelziweiyou.Text = "廉贞昏";

                        labeltianfuzi.Text = "太阴科辉";
                        labeltianfuchou.Text = "贪狼忌辉";
                        labeltianfuyin.Text = "巨门权辉";
                        labeltianfumao.Text = "天相辉";
                        labeltianfuchen.Text = "天梁辉";
                        labeltianfusi.Text = "七杀昏";
                        labeltianfuyou.Text = "破军禄黑";
                    }
                    if (ziweixingzuobiaowu == 1)
                    {
                        labelziweisi.Text = "天机昏";
                        labelziweimao.Text = "太阳辉";
                        labelziweiyin.Text = "武曲亮";
                        labelziweichou.Text = "天同暗";
                        labelziweixu.Text = "廉贞昏";

                        labeltianfuhai.Text = "太阴科辉";
                        labeltianfuzi.Text = "贪狼忌耀";
                        labeltianfuchou.Text = "巨门权暗";
                        labeltianfuyin.Text = "天相辉";
                        labeltianfumao.Text = "天梁辉";
                        labeltianfuchen.Text = "七杀辉";
                        labeltianfushen.Text = "破军禄亮";
                    }
                    if (ziweixingzuobiaowei == 1)
                    {
                        labelziweiwu.Text = "天机辉";
                        labelziweichen.Text = "太阳耀";
                        labelziweimao.Text = "武曲明";
                        labelziweiyin.Text = "天同明";
                        labelziweihai.Text = "廉贞黑";

                        labeltianfuxu.Text = "太阴科耀";
                        labeltianfuhai.Text = "贪狼忌黑";
                        labeltianfuzi.Text = "巨门权耀";
                        labeltianfuchou.Text = "天相辉";
                        labeltianfuyin.Text = "天梁辉";
                        labeltianfumao.Text = "七杀耀";
                        labeltianfuwei.Text = "破军禄耀";
                    }
                    if (ziweixingzuobiaoshen == 1)
                    {
                        labelziweiwei.Text = "天机黑";
                        labelziweisi.Text = "太阳耀";
                        labelziweichen.Text = "武曲辉";
                        labelziweimao.Text = "天同昏";
                        labelziweizi.Text = "廉贞昏";

                        labeltianfuyou.Text = "太阴科暗";
                        labeltianfuxu.Text = "贪狼忌辉";
                        labeltianfuhai.Text = "巨门权耀";
                        labeltianfuzi.Text = "天相辉";
                        labeltianfuchou.Text = "天梁耀";
                        labeltianfuyin.Text = "七杀辉";
                        labeltianfuwu.Text = "破军禄耀";
                    }
                    if (ziweixingzuobiaoyou == 1)
                    {
                        labelziweishen.Text = "天机亮";
                        labelziweiwu.Text = "太阳耀";
                        labelziweisi.Text = "武曲昏";
                        labelziweichen.Text = "天同昏";
                        labelziweichou.Text = "廉贞明";

                        labeltianfushen.Text = "太阴科明";
                        labeltianfuyou.Text = "贪狼忌明";
                        labeltianfuxu.Text = "巨门权黑";
                        labeltianfuhai.Text = "天相亮";
                        labeltianfuzi.Text = "天梁辉";
                        labeltianfuchou.Text = "七杀辉";
                        labeltianfusi.Text = "破军禄昏";
                    }
                    if (ziweixingzuobiaoxu == 1)
                    {
                        labelziweiyou.Text = "天机耀";
                        labelziweiwei.Text = "太阳亮";
                        labelziweiwu.Text = "武曲耀";
                        labelziweisi.Text = "天同辉";
                        labelziweiyin.Text = "廉贞辉";

                        labeltianfusi.Text = "太阴科黑";
                        labeltianfuwu.Text = "贪狼忌耀";
                        labeltianfuwei.Text = "巨门权暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军禄亮";
                    }
                    if (ziweixingzuobiaohai == 1)
                    {
                        labelziweixu.Text = "天机明";
                        labelziweishen.Text = "太阳亮";
                        labelziweiwei.Text = "武曲辉";
                        labelziweiwu.Text = "天同黑";
                        labelziweimao.Text = "廉贞昏";

                        labeltianfuwu.Text = "太阴科暗";
                        labeltianfuwei.Text = "贪狼忌辉";
                        labeltianfushen.Text = "巨门权辉";
                        labeltianfuyou.Text = "天相黑";
                        labeltianfuxu.Text = "天梁辉";
                        labeltianfuhai.Text = "七杀昏";
                        labeltianfumao.Text = "破军禄黑";
                    }
                    if (ziweixingzuobiaozi == 1)
                    {
                        labelziweihai.Text = "天机昏";
                        labelziweiyou.Text = "太阳黑";
                        labelziweishen.Text = "武曲亮";
                        labelziweiwei.Text = "天同暗";
                        labelziweichen.Text = "廉贞明";

                        labeltianfusi.Text = "太阴科黑";
                        labeltianfuwu.Text = "贪狼忌耀";
                        labeltianfuwei.Text = "巨门权暗";
                        labeltianfushen.Text = "天相辉";
                        labeltianfuyou.Text = "天梁亮";
                        labeltianfuxu.Text = "七杀辉";
                        labeltianfuyin.Text = "破军禄亮";
                    }
                    if (ziweixingzuobiaochou == 1)
                    {
                        labelziweizi.Text = "天机辉";
                        labelziweixu.Text = "太阳暗";
                        labelziweiyou.Text = "武曲明";
                        labelziweishen.Text = "天同耀";
                        labelziweisi.Text = "廉贞黑";

                        labeltianfuchen.Text = "太阴科黑";
                        labeltianfusi.Text = "贪狼忌黑";
                        labeltianfuwu.Text = "巨门权耀";
                        labeltianfuwei.Text = "天相亮";
                        labeltianfushen.Text = "天梁黑";
                        labeltianfuyou.Text = "七杀辉";
                        labeltianfuchou.Text = "破军禄耀";
                    }
                    //文昌文曲//恩光天贵
                    if (jia == jia)
                    {
                        labelwenchangyin.Text = "";
                        labelwenchangmao.Text = "";
                        labelwenchangchen.Text = "";
                        labelwenchangsi.Text = "";
                        labelwenchangwu.Text = "";
                        labelwenchangwei.Text = "";
                        labelwenchangshen.Text = "";
                        labelwenchangyou.Text = "";
                        labelwenchangxu.Text = "";
                        labelwenchanghai.Text = "";
                        labelwenchangzi.Text = "";
                        labelwenchangchou.Text = "";

                        labelwenquyin.Text = "";
                        labelwenqumao.Text = "";
                        labelwenquchen.Text = "";
                        labelwenqusi.Text = "";
                        labelwenquwu.Text = "";
                        labelwenquwei.Text = "";
                        labelwenqushen.Text = "";
                        labelwenquyou.Text = "";
                        labelwenquxu.Text = "";
                        labelwenquhai.Text = "";
                        labelwenquzi.Text = "";
                        labelwenquchou.Text = "";

                        //安文昌文曲
                        int enguang = 0;
                        int tiangui = 0;
                        if (sdz == zii)
                        {
                            labelwenchangxu.Text = "文昌黑"; enguang = 9;
                            labelwenquchen.Text = "文曲亮"; tiangui = 3;
                        }
                        if (sdz == chou)
                        {
                            labelwenchangyou.Text = "文昌辉"; enguang = 8;
                            labelwenqusi.Text = "文曲辉"; tiangui = 4;
                        }
                        if (sdz == yin)
                        {
                            labelwenchangshen.Text = "文昌亮"; enguang = 7;
                            labelwenquwu.Text = "文曲黑"; tiangui = 5;
                        }
                        if (sdz == mao)
                        {
                            labelwenchangwei.Text = "文昌明"; enguang = 6;
                            labelwenquwei.Text = "文曲耀"; tiangui = 6;
                        }
                        if (sdz == chen)
                        {
                            labelwenchangwu.Text = "文昌黑"; enguang = 5;
                            labelwenqushen.Text = "文曲亮"; tiangui = 7;
                        }
                        if (sdz == sii)
                        {
                            labelwenchangsi.Text = "文昌辉"; enguang = 4;
                            labelwenquyou.Text = "文曲辉"; tiangui = 8;
                        }
                        if (sdz == wuma)
                        {
                            labelwenchangchen.Text = "文昌亮"; enguang = 3;
                            labelwenquxu.Text = "文曲黑"; tiangui = 9;
                        }
                        if (sdz == wei)
                        {
                            labelwenchangmao.Text = "文昌明"; enguang = 2;
                            labelwenquhai.Text = "文曲耀"; tiangui = 10;
                        }
                        if (sdz == shen)
                        {
                            labelwenchangyin.Text = "文昌黑"; enguang = 1;
                            labelwenquzi.Text = "文曲亮"; tiangui = 11;
                        }
                        if (sdz == you)
                        {
                            labelwenchangchou.Text = "文昌辉"; enguang = 12;
                            labelwenquchou.Text = "文曲辉"; tiangui = 12;
                        }
                        if (sdz == xuu)
                        {
                            labelwenchangzi.Text = "文昌亮"; enguang = 11;
                            labelwenquyin.Text = "文曲昏"; tiangui = 1;
                        }
                        if (sdz == hai)
                        {
                            labelwenchanghai.Text = "文昌明"; enguang = 10;
                            labelwenqumao.Text = "文曲耀"; tiangui = 2;
                        }

                        labeltianguiyin.Text = "";
                        labeltianguimao.Text = "";
                        labeltianguichen.Text = "";
                        labeltianguisi.Text = "";
                        labeltianguiwu.Text = "";
                        labeltianguiwei.Text = "";
                        labeltianguishen.Text = "";
                        labeltianguiyou.Text = "";
                        labeltianguixu.Text = "";
                        labeltianguihai.Text = "";
                        labeltianguizi.Text = "";
                        labeltianguichou.Text = "";

                        labelenguangyin.Text = "";
                        labelenguangmao.Text = "";
                        labelenguangchen.Text = "";
                        labelenguangsi.Text = "";
                        labelenguangwu.Text = "";
                        labelenguangwei.Text = "";
                        labelenguangshen.Text = "";
                        labelenguangyou.Text = "";
                        labelenguangxu.Text = "";
                        labelenguanghai.Text = "";
                        labelenguangzi.Text = "";
                        labelenguangchou.Text = "";

                        enguang += dayNL - 2;
                        tiangui += dayNL - 2;
                        while (enguang >= 24)
                        {
                            enguang -= 12;
                        }
                        while (tiangui >= 24)
                        {
                            tiangui -= 12;
                        }

                        if (enguang == 1 || enguang == 13)
                        {
                            labelenguangyin.Text = "恩光";
                        }
                        if (enguang == 2 || enguang == 14)
                        {
                            labelenguangmao.Text = "恩光";
                        }
                        if (enguang == 3 || enguang == 15)
                        {
                            labelenguangchen.Text = "恩光";
                        }
                        if (enguang == 4 || enguang == 16)
                        {
                            labelenguangsi.Text = "恩光";
                        }
                        if (enguang == 5 || enguang == 17)
                        {
                            labelenguangwu.Text = "恩光";
                        }
                        if (enguang == 6 || enguang == 18)
                        {
                            labelenguangwei.Text = "恩光";
                        }
                        if (enguang == 7 || enguang == 19)
                        {
                            labelenguangshen.Text = "恩光";
                        }
                        if (enguang == 8 || enguang == 20)
                        {
                            labelenguangyou.Text = "恩光";
                        }
                        if (enguang == 9 || enguang == 21)
                        {
                            labelenguangxu.Text = "恩光";
                        }
                        if (enguang == 10 || enguang == 22)
                        {
                            labelenguanghai.Text = "恩光";
                        }
                        if (enguang == 11 || enguang == 23)
                        {
                            labelenguangzi.Text = "恩光";
                        }
                        if (enguang == 12)
                        {
                            labelenguangchou.Text = "恩光";
                        }

                        if (tiangui == 1 || tiangui == 13)
                        {
                            labeltianguiyin.Text = "天贵";
                        }
                        if (tiangui == 2 || tiangui == 14)
                        {
                            labeltianguimao.Text = "天贵";
                        }
                        if (tiangui == 3 || tiangui == 15)
                        {
                            labeltianguichen.Text = "天贵";
                        }
                        if (tiangui == 4 || tiangui == 16)
                        {
                            labeltianguisi.Text = "天贵";
                        }
                        if (tiangui == 5 || tiangui == 17)
                        {
                            labeltianguiwu.Text = "天贵";
                        }
                        if (tiangui == 6 || tiangui == 18)
                        {
                            labeltianguiwei.Text = "天贵";
                        }
                        if (tiangui == 7 || tiangui == 19)
                        {
                            labeltianguishen.Text = "天贵";
                        }
                        if (tiangui == 8 || tiangui == 20)
                        {
                            labeltianguiyou.Text = "天贵";
                        }
                        if (tiangui == 9 || tiangui == 21)
                        {
                            labeltianguixu.Text = "天贵";
                        }
                        if (tiangui == 10 || tiangui == 22)
                        {
                            labeltianguihai.Text = "天贵";
                        }
                        if (tiangui == 11 || tiangui == 23)
                        {
                            labeltianguizi.Text = "天贵";
                        }
                        if (tiangui == 12)
                        {
                            labeltianguichou.Text = "天贵";
                        }

                    }
                    //左辅右弼//三台八座
                    if (jia == jia)
                    {
                        labelyoubiyin.Text = "";
                        labelyoubimao.Text = "";
                        labelyoubichen.Text = "";
                        labelyoubisi.Text = "";
                        labelyoubiwu.Text = "";
                        labelyoubiwei.Text = "";
                        labelyoubishen.Text = "";
                        labelyoubiyou.Text = "";
                        labelyoubixu.Text = "";
                        labelyoubihai.Text = "";
                        labelyoubizi.Text = "";
                        labelyoubichou.Text = "";

                        labelzuofuyin.Text = "";
                        labelzuofumao.Text = "";
                        labelzuofuchen.Text = "";
                        labelzuofusi.Text = "";
                        labelzuofuwu.Text = "";
                        labelzuofuwei.Text = "";
                        labelzuofushen.Text = "";
                        labelzuofuyou.Text = "";
                        labelzuofuxu.Text = "";
                        labelzuofuhai.Text = "";
                        labelzuofuzi.Text = "";
                        labelzuofuchou.Text = "";

                        labelsantaiyin.Text = "";
                        labelsantaimao.Text = "";
                        labelsantaichen.Text = "";
                        labelsantaisi.Text = "";
                        labelsantaiwu.Text = "";
                        labelsantaiwei.Text = "";
                        labelsantaishen.Text = "";
                        labelsantaiyou.Text = "";
                        labelsantaixu.Text = "";
                        labelsantaihai.Text = "";
                        labelsantaizi.Text = "";
                        labelsantaichou.Text = "";

                        labelbazuoyin.Text = "";
                        labelbazuomao.Text = "";
                        labelbazuochen.Text = "";
                        labelbazuosi.Text = "";
                        labelbazuowu.Text = "";
                        labelbazuowei.Text = "";
                        labelbazuoshen.Text = "";
                        labelbazuoyou.Text = "";
                        labelbazuoxu.Text = "";
                        labelbazuohai.Text = "";
                        labelbazuozi.Text = "";
                        labelbazuochou.Text = "";

                        int santai = 0;
                        int bazuo = 0;

                        if (monthNL == 1)
                        {
                            labelyoubixu.Text = "右弼"; bazuo = 9;
                            labelzuofuchen.Text = "左辅"; santai = 3;
                        }
                        if (monthNL == 2)
                        {
                            labelyoubiyou.Text = "右弼"; bazuo = 8;
                            labelzuofusi.Text = "左辅"; santai = 4;
                        }
                        if (monthNL == 3)
                        {
                            labelyoubishen.Text = "右弼"; bazuo = 7;
                            labelzuofuwu.Text = "左辅"; santai = 5;
                        }
                        if (monthNL == 4)
                        {
                            labelyoubiwei.Text = "右弼"; bazuo = 6;
                            labelzuofuwei.Text = "左辅"; santai = 6;
                        }
                        if (monthNL == 5)
                        {
                            labelyoubiwu.Text = "右弼"; bazuo = 5;
                            labelzuofushen.Text = "左辅"; santai = 7;
                        }
                        if (monthNL == 6)
                        {
                            labelyoubisi.Text = "右弼"; bazuo = 4;
                            labelzuofuyou.Text = "左辅"; santai = 8;
                        }
                        if (monthNL == 7)
                        {
                            labelyoubichen.Text = "右弼"; bazuo = 3;
                            labelzuofuxu.Text = "左辅"; santai = 9;
                        }
                        if (monthNL == 8)
                        {
                            labelyoubimao.Text = "右弼"; bazuo = 2;
                            labelzuofuhai.Text = "左辅"; santai = 10;
                        }
                        if (monthNL == 9)
                        {
                            labelyoubiyin.Text = "右弼"; bazuo = 1;
                            labelzuofuzi.Text = "左辅"; santai = 11;
                        }
                        if (monthNL == 10)
                        {
                            labelyoubichou.Text = "右弼"; bazuo = 12;
                            labelzuofuchou.Text = "左辅"; santai = 12;
                        }
                        if (monthNL == 11)
                        {
                            labelyoubizi.Text = "右弼"; bazuo = 11;
                            labelzuofuyin.Text = "左辅"; santai = 1;
                        }
                        if (monthNL == 12)
                        {
                            labelyoubihai.Text = "右弼"; bazuo = 10;
                            labelzuofumao.Text = "左辅"; santai = 2;
                        }
                        bazuo += dayNL - 1;
                        santai += dayNL - 1;
                        while (bazuo >= 24)
                        {
                            bazuo -= 12;
                        }
                        while (santai >= 24)
                        {
                            santai -= 12;
                        }

                        if (bazuo == 1 || bazuo == 13)
                        {
                            labelbazuoyin.Text = "八座";
                        }
                        if (bazuo == 2 || bazuo == 14)
                        {
                            labelbazuomao.Text = "八座";
                        }
                        if (bazuo == 3 || bazuo == 15)
                        {
                            labelbazuochen.Text = "八座";
                        }
                        if (bazuo == 4 || bazuo == 16)
                        {
                            labelbazuosi.Text = "八座";
                        }
                        if (bazuo == 5 || bazuo == 17)
                        {
                            labelbazuowu.Text = "八座";
                        }
                        if (bazuo == 6 || bazuo == 18)
                        {
                            labelbazuowei.Text = "八座";
                        }
                        if (bazuo == 7 || bazuo == 19)
                        {
                            labelbazuoshen.Text = "八座";
                        }
                        if (bazuo == 8 || bazuo == 20)
                        {
                            labelbazuoyou.Text = "八座";
                        }
                        if (bazuo == 9 || bazuo == 21)
                        {
                            labelbazuoxu.Text = "八座";
                        }
                        if (bazuo == 10 || bazuo == 22)
                        {
                            labelbazuohai.Text = "八座";
                        }
                        if (bazuo == 11 || bazuo == 23)
                        {
                            labelbazuozi.Text = "八座";
                        }
                        if (bazuo == 12)
                        {
                            labelbazuochou.Text = "八座";
                        }

                        if (santai == 1 || santai == 13)
                        {
                            labelsantaiyin.Text = "三台";
                        }
                        if (santai == 2 || santai == 14)
                        {
                            labelsantaimao.Text = "三台";
                        }
                        if (santai == 3 || santai == 15)
                        {
                            labelsantaichen.Text = "三台";
                        }
                        if (santai == 4 || santai == 16)
                        {
                            labelsantaisi.Text = "三台";
                        }
                        if (santai == 5 || santai == 17)
                        {
                            labelsantaiwu.Text = "三台";
                        }
                        if (santai == 6 || santai == 18)
                        {
                            labelsantaiwei.Text = "三台";
                        }
                        if (santai == 7 || santai == 19)
                        {
                            labelsantaishen.Text = "三台";
                        }
                        if (santai == 8 || santai == 20)
                        {
                            labelsantaiyou.Text = "三台";
                        }
                        if (santai == 9 || santai == 21)
                        {
                            labelsantaixu.Text = "三台";
                        }
                        if (santai == 10 || santai == 22)
                        {
                            labelsantaihai.Text = "三台";
                        }
                        if (santai == 11 || santai == 23)
                        {
                            labelsantaizi.Text = "三台";
                        }
                        if (santai == 12)
                        {
                            labelsantaichou.Text = "三台";
                        }

                    }
                }
            }
            //天魁天钺
            if (jia == jia)
            {
                labeltiankuiyin.Text = "";
                labeltiankuimao.Text = "";
                labeltiankuichen.Text = "";
                labeltiankuisi.Text = "";
                labeltiankuiwu.Text = "";
                labeltiankuiwei.Text = "";
                labeltiankuishen.Text = "";
                labeltiankuiyou.Text = "";
                labeltiankuixu.Text = "";
                labeltiankuihai.Text = "";
                labeltiankuizi.Text = "";
                labeltiankuichou.Text = "";


                if (ntg == jia || ntg == wuu || ntg == geng)
                {
                    labeltiankuichou.Text = "天魁";
                    labeltiankuiwei.Text = "天钺";
                }
                if (ntg == yii || ntg == jii)
                {
                    labeltiankuizi.Text = "天魁";
                    labeltiankuishen.Text = "天钺";
                }
                if (ntg == bing || ntg == ding)
                {
                    labeltiankuihai.Text = "天魁";
                    labeltiankuiyou.Text = "天钺";
                }
                if (ntg == xin)
                {
                    labeltiankuiyin.Text = "天魁";
                    labeltiankuiwu.Text = "天钺";
                }
                if (ntg == ren || ntg == gui)
                {
                    labeltiankuimao.Text = "天魁";
                    labeltiankuisi.Text = "天钺";
                }

            }
            //陀罗禄存擎羊
            if (jia == jia)
            {
                labellucunyin.Text = "";
                labellucunmao.Text = "";
                labellucunchen.Text = "";
                labellucunsi.Text = "";
                labellucunwu.Text = "";
                labellucunwei.Text = "";
                labellucunshen.Text = "";
                labellucunyou.Text = "";
                labellucunxu.Text = "";
                labellucunhai.Text = "";
                labellucunzi.Text = "";
                labellucunchou.Text = "";

                if (ntg == jia)
                {
                    labellucunmao.Text = "擎羊黑";
                    labellucunyin.Text = "禄存";
                    labellucunchou.Text = "陀罗辉";
                }
                if (ntg == yii)
                {
                    labellucunchen.Text = "擎羊辉";
                    labellucunmao.Text = "禄存";
                    labellucunyin.Text = "陀罗黑";
                }
                if (ntg == bing || ntg == wuu)
                {
                    labellucunwei.Text = "擎羊辉";
                    labellucunsi.Text = "禄存";
                    labellucunchen.Text = "陀罗辉";
                }
                if (ntg == ding || ntg == jii)
                {
                    labellucunwei.Text = "擎羊辉";
                    labellucunwu.Text = "禄存";
                    labellucunsi.Text = "陀罗黑";
                }
                if (ntg == geng)
                {
                    labellucunyou.Text = "擎羊黑";
                    labellucunshen.Text = "禄存";
                    labellucunwei.Text = "陀罗辉";
                }
                if (ntg == xin)
                {
                    labellucunxu.Text = "擎羊辉";
                    labellucunyou.Text = "禄存";
                    labellucunshen.Text = "陀罗黑";
                }
                if (ntg == ren)
                {
                    labellucunzi.Text = "擎羊黑";
                    labellucunhai.Text = "禄存";
                    labellucunxu.Text = "陀罗辉";
                }
                if (ntg == gui)
                {
                    labellucunchou.Text = "擎羊辉";
                    labellucunzi.Text = "禄存";
                    labellucunhai.Text = "陀罗黑";
                }
            }
            //火星铃星
            if (jia == jia)
            {
                labelhuoxingyin.Text = "";
                labelhuoxingmao.Text = "";
                labelhuoxingchen.Text = "";
                labelhuoxingsi.Text = "";
                labelhuoxingwu.Text = "";
                labelhuoxingwei.Text = "";
                labelhuoxingshen.Text = "";
                labelhuoxingyou.Text = "";
                labelhuoxingxu.Text = "";
                labelhuoxinghai.Text = "";
                labelhuoxingzi.Text = "";
                labelhuoxingchou.Text = "";

                if (ndz == yin || ndz == wuma || ndz == xuu)
                {
                    if (sdz == zii)
                    {
                        labelhuoxingchou.Text = "火星亮";
                        labelhuoxingmao.Text = "铃星明";
                    }
                    if (sdz == chou)
                    {
                        labelhuoxingyin.Text = "火星辉";
                        labelhuoxingchen.Text = "铃星黑";
                    }
                    if (sdz == yin)
                    {
                        labelhuoxingmao.Text = "火星明";
                        labelhuoxingsi.Text = "铃星亮";
                    }
                    if (sdz == mao)
                    {
                        labelhuoxingchen.Text = "火星黑";
                        labelhuoxingwu.Text = "铃星辉";
                    }
                    if (sdz == chen)
                    {
                        labelhuoxingsi.Text = "火星亮";
                        labelhuoxingwei.Text = "铃星明";
                    }
                    if (sdz == sii)
                    {
                        labelhuoxingwu.Text = "火星辉";
                        labelhuoxingshen.Text = "铃星黑";
                    }
                    if (sdz == wuma)
                    {
                        labelhuoxingwei.Text = "火星明";
                        labelhuoxingyou.Text = "铃星亮";
                    }
                    if (sdz == wei)
                    {
                        labelhuoxingshen.Text = "火星黑";
                        labelhuoxingxu.Text = "铃星辉";
                    }
                    if (sdz == shen)
                    {
                        labelhuoxingyou.Text = "火星亮";
                        labelhuoxinghai.Text = "铃星明";
                    }
                    if (sdz == you)
                    {
                        labelhuoxingxu.Text = "火星辉";
                        labelhuoxingzi.Text = "铃星黑";
                    }
                    if (sdz == xuu)
                    {
                        labelhuoxinghai.Text = "火星明";
                        labelhuoxingchou.Text = "铃星亮";
                    }
                    if (sdz == hai)
                    {
                        labelhuoxingzi.Text = "火星黑";
                        labelhuoxingyin.Text = "铃星辉";
                    }
                }
                if (ndz == sii || ndz == you || ndz == chou)
                {
                    if (sdz == zii)
                    {
                        labelhuoxingmao.Text = "火星明";
                        labelhuoxingxu.Text = "铃星辉";
                    }
                    if (sdz == chou)
                    {
                        labelhuoxingchen.Text = "火星黑";
                        labelhuoxinghai.Text = "铃星明明";
                    }
                    if (sdz == yin)
                    {
                        labelhuoxingsi.Text = "火星亮";
                        labelhuoxingzi.Text = "铃星黑";
                    }
                    if (sdz == mao)
                    {
                        labelhuoxingwu.Text = "火星辉";
                        labelhuoxingchou.Text = "铃星亮";
                    }
                    if (sdz == chen)
                    {
                        labelhuoxingwei.Text = "火星明";
                        labelhuoxingyin.Text = "铃星辉";
                    }
                    if (sdz == sii)
                    {
                        labelhuoxingshen.Text = "火星黑";
                        labelhuoxingmao.Text = "铃星明";
                    }
                    if (sdz == wuma)
                    {
                        labelhuoxingyou.Text = "火星亮";
                        labelhuoxingchen.Text = "铃星黑";
                    }
                    if (sdz == wei)
                    {
                        labelhuoxingxu.Text = "火星辉";
                        labelhuoxingsi.Text = "铃星亮";
                    }
                    if (sdz == shen)
                    {
                        labelhuoxinghai.Text = "火星明";
                        labelhuoxingwu.Text = "铃星辉";
                    }
                    if (sdz == you)
                    {
                        labelhuoxingzi.Text = "火星黑";
                        labelhuoxingwei.Text = "铃星明";
                    }
                    if (sdz == xuu)
                    {
                        labelhuoxingchou.Text = "火星亮";
                        labelhuoxingshen.Text = "铃星黑";
                    }
                    if (sdz == hai)
                    {
                        labelhuoxingyin.Text = "火星辉";
                        labelhuoxingyou.Text = "铃星亮";
                    }
                }
                if (ndz == shen || ndz == zii || ndz == chen)
                {
                    if (sdz == zii)
                    {
                        labelhuoxingyin.Text = "火星辉";
                        labelhuoxingxu.Text = "铃星辉";
                    }
                    if (sdz == chou)
                    {
                        labelhuoxingmao.Text = "火星明";
                        labelhuoxinghai.Text = "铃星明明";
                    }
                    if (sdz == yin)
                    {
                        labelhuoxingchen.Text = "火星黑";
                        labelhuoxingzi.Text = "铃星黑";
                    }
                    if (sdz == mao)
                    {
                        labelhuoxingsi.Text = "火星亮";
                        labelhuoxingchou.Text = "铃星亮";
                    }
                    if (sdz == chen)
                    {
                        labelhuoxingwu.Text = "火星辉";
                        labelhuoxingyin.Text = "铃星辉";
                    }
                    if (sdz == sii)
                    {
                        labelhuoxingwei.Text = "火星明";
                        labelhuoxingmao.Text = "铃星明";
                    }
                    if (sdz == wuma)
                    {
                        labelhuoxingshen.Text = "火星黑";
                        labelhuoxingchen.Text = "铃星黑";
                    }
                    if (sdz == wei)
                    {
                        labelhuoxingyou.Text = "火星亮";
                        labelhuoxingsi.Text = "铃星亮";
                    }
                    if (sdz == shen)
                    {
                        labelhuoxingxu.Text = "火星辉";
                        labelhuoxingwu.Text = "铃星辉";
                    }
                    if (sdz == you)
                    {
                        labelhuoxinghai.Text = "火星明";
                        labelhuoxingwei.Text = "铃星明";
                    }
                    if (sdz == xuu)
                    {
                        labelhuoxingzi.Text = "火星黑";
                        labelhuoxingshen.Text = "铃星黑";
                    }
                    if (sdz == hai)
                    {
                        labelhuoxingchou.Text = "火星亮";
                        labelhuoxingyou.Text = "铃星亮";
                    }
                }
                if (ndz == hai || ndz == mao || ndz == wei)
                {
                    if (sdz == zii)
                    {
                        labelhuoxingyou.Text = "火星亮";
                        labelhuoxingxu.Text = "铃星辉";
                    }
                    if (sdz == chou)
                    {
                        labelhuoxingxu.Text = "火星辉";
                        labelhuoxinghai.Text = "铃星明明";
                    }
                    if (sdz == yin)
                    {
                        labelhuoxinghai.Text = "火星明";
                        labelhuoxingzi.Text = "铃星黑";
                    }
                    if (sdz == mao)
                    {
                        labelhuoxingzi.Text = "火星黑";
                        labelhuoxingchou.Text = "铃星亮";
                    }
                    if (sdz == chen)
                    {
                        labelhuoxingchou.Text = "火星亮";
                        labelhuoxingyin.Text = "铃星辉";
                    }
                    if (sdz == sii)
                    {
                        labelhuoxingyin.Text = "火星辉";
                        labelhuoxingmao.Text = "铃星明";
                    }
                    if (sdz == wuma)
                    {
                        labelhuoxingmao.Text = "火星明";
                        labelhuoxingchen.Text = "铃星黑";
                    }
                    if (sdz == wei)
                    {
                        labelhuoxingchen.Text = "火星黑";
                        labelhuoxingsi.Text = "铃星亮";
                    }
                    if (sdz == shen)
                    {
                        labelhuoxingsi.Text = "火星亮";
                        labelhuoxingwu.Text = "铃星辉";
                    }
                    if (sdz == you)
                    {
                        labelhuoxingwu.Text = "火星辉";
                        labelhuoxingwei.Text = "铃星明";
                    }
                    if (sdz == xuu)
                    {
                        labelhuoxingwei.Text = "火星明";
                        labelhuoxingshen.Text = "铃星黑";
                    }
                    if (sdz == hai)
                    {
                        labelhuoxingshen.Text = "火星黑";
                        labelhuoxingyou.Text = "铃星亮";
                    }
                }
            }
            //天马
            if (jia == jia)
            {
                labeltianmayin.Text = "";
                labeltianmasi.Text = "";
                labeltianmashen.Text = "";
                labeltianmahai.Text = "";


                if (ndz == yin || ndz == wuma || ndz == xuu)
                {
                    labeltianmashen.Text = "天马";
                }
                if (ndz == sii || ndz == you || ndz == chou)
                {
                    labeltianmahai.Text = "天马";
                }
                if (ndz == shen || ndz == zii || ndz == chen)
                {
                    labeltianmayin.Text = "天马";
                }
                if (ndz == hai || ndz == mao || ndz == wei)
                {
                    labeltianmasi.Text = "天马";
                }
            }
            //地空地劫
            if (jia == jia)
            {
                labeldikongyin.Text = "";
                labeldikongmao.Text = "";
                labeldikongchen.Text = "";
                labeldikongsi.Text = "";
                labeldikongwu.Text = "";
                labeldikongwei.Text = "";
                labeldikongshen.Text = "";
                labeldikongyou.Text = "";
                labeldikongxu.Text = "";
                labeldikonghai.Text = "";
                labeldikongzi.Text = "";
                labeldikongchou.Text = "";

                labeldijieyin.Text = "";
                labeldijiemao.Text = "";
                labeldijiechen.Text = "";
                labeldijiesi.Text = "";
                labeldijiewu.Text = "";
                labeldijiewei.Text = "";
                labeldijieshen.Text = "";
                labeldijieyou.Text = "";
                labeldijiexu.Text = "";
                labeldijiehai.Text = "";
                labeldijiezi.Text = "";
                labeldijiechou.Text = "";

                if (sdz == zii)
                {
                    labeldikonghai.Text = "地空";
                    labeldijiehai.Text = "地劫";
                }
                if (sdz == chou)
                {
                    labeldikongxu.Text = "地空";
                    labeldijiezi.Text = "地劫";
                }
                if (sdz == yin)
                {
                    labeldikongyou.Text = "地空";
                    labeldijiechou.Text = "地劫";
                }
                if (sdz == mao)
                {
                    labeldikongshen.Text = "地空";
                    labeldijieyin.Text = "地劫";
                }
                if (sdz == chen)
                {
                    labeldikongwei.Text = "地空";
                    labeldijiemao.Text = "地劫";
                }
                if (sdz == sii)
                {
                    labeldikongwu.Text = "地空";
                    labeldijiechen.Text = "地劫";
                }
                if (sdz == wuma)
                {
                    labeldikongsi.Text = "地空";
                    labeldijiesi.Text = "地劫";
                }
                if (sdz == wei)
                {
                    labeldikongchen.Text = "地空";
                    labeldijiewu.Text = "地劫";
                }
                if (sdz == shen)
                {
                    labeldikongmao.Text = "地空";
                    labeldijiewei.Text = "地劫";
                }
                if (sdz == you)
                {
                    labeldikongyin.Text = "地空";
                    labeldijieshen.Text = "地劫";
                }
                if (sdz == xuu)
                {
                    labeldikongchou.Text = "地空";
                    labeldijieyou.Text = "地劫";
                }
                if (sdz == hai)
                {
                    labeldikongzi.Text = "地空";
                    labeldijiexu.Text = "地劫";
                }
            }
            //解神
            if (jia == jia)
            {
                labeljieshenyin.Text = "";
                labeljieshenchen.Text = "";
                labeljieshenwu.Text = "";
                labeljieshenshen.Text = "";
                labeljieshenxu.Text = "";
                labeljieshenzi.Text = "";

                if (monthNL == 1 || monthNL == 2)
                {
                    labeljieshenshen.Text = "解神";
                }
                if (monthNL == 3 || monthNL == 4)
                {
                    labeljieshenxu.Text = "解神";
                }
                if (monthNL == 5 || monthNL == 6)
                {
                    labeljieshenzi.Text = "解神";
                }
                if (monthNL == 7 || monthNL == 8)
                {
                    labeljieshenyin.Text = "解神";
                }
                if (monthNL == 9 || monthNL == 10)
                {
                    labeljieshenchen.Text = "解神";
                }
                if (monthNL == 11 || monthNL == 12)
                {
                    labeljieshenwu.Text = "解神";
                }

            }
            //天巫
            if (jia == jia)
            {
                labeltianwuyin.Text = "";
                labeltianwushen.Text = "";
                labeltianwusi.Text = "";
                labeltianwuhai.Text = "";

                if (monthNL == 1 || monthNL == 5 || monthNL == 9)
                {
                    labeltianwusi.Text = "天巫";
                }
                if (monthNL == 3 || monthNL == 7 || monthNL == 11)
                {
                    labeltianwuyin.Text = "天巫";
                }
                if (monthNL == 2 || monthNL == 6 || monthNL == 10)
                {
                    labeltianwushen.Text = "天巫";
                }
                if (monthNL == 4 || monthNL == 8 || monthNL == 12)
                {
                    labeltianwuhai.Text = "天巫";
                }

            }
            //天月
            if (jia == jia)
            {
                labeltianyue2yin.Text = "";
                labeltianyue2mao.Text = "";
                labeltianyue2chen.Text = "";
                labeltianyue2si.Text = "";
                labeltianyue2wu.Text = "";
                labeltianyue2wei.Text = "";
                labeltianyue2xu.Text = "";
                labeltianyue2hai.Text = "";

                if (monthNL == 1 || monthNL == 11)
                {
                    labeltianyue2xu.Text = "天月";
                }
                if (monthNL == 2)
                {
                    labeltianyue2si.Text = "天月";
                }
                if (monthNL == 3)
                {
                    labeltianyue2chen.Text = "天月";
                }
                if (monthNL == 4 || monthNL == 9 || monthNL == 12)
                {
                    labeltianyue2yin.Text = "天月";
                }
                if (monthNL == 5 || monthNL == 8)
                {
                    labeltianyue2wei.Text = "天月";
                }
                if (monthNL == 6)
                {
                    labeltianyue2mao.Text = "天月";
                }
                if (monthNL == 7)
                {
                    labeltianyue2hai.Text = "天月";
                }
                if (monthNL == 10)
                {
                    labeltianyue2wu.Text = "天月";
                }

            }
            //天殇天使
            if (jia == jia)
            {

                labeltianshiyin.Text = "";
                labeltianshimao.Text = "";
                labeltianshichen.Text = "";
                labeltianshisi.Text = "";
                labeltianshiwu.Text = "";
                labeltianshiwei.Text = "";
                labeltianshishen.Text = "";
                labeltianshiyou.Text = "";
                labeltianshixu.Text = "";
                labeltianshihai.Text = "";
                labeltianshizi.Text = "";
                labeltianshichou.Text = "";

                if (dayunyin == 1)
                {
                    labeltianshiwei.Text = "天殇";
                    labeltianshiyou.Text = "天使";
                }
                if (dayunmao == 1)
                {
                    labeltianshishen.Text = "天殇";
                    labeltianshixu.Text = "天使";
                }
                if (dayunchen == 1)
                {
                    labeltianshiyou.Text = "天殇";
                    labeltianshihai.Text = "天使";
                }
                if (dayunsi == 1)
                {
                    labeltianshixu.Text = "天殇";
                    labeltianshizi.Text = "天使";
                }
                if (dayunwu == 1)
                {
                    labeltianshihai.Text = "天殇";
                    labeltianshichou.Text = "天使";
                }
                if (dayunwei == 1)
                {
                    labeltianshizi.Text = "天殇";
                    labeltianshiyin.Text = "天使";
                }
                if (dayunshen == 1)
                {
                    labeltianshichou.Text = "天殇";
                    labeltianshimao.Text = "天使";
                }
                if (dayunyou == 1)
                {
                    labeltianshiyin.Text = "天殇";
                    labeltianshichen.Text = "天使";
                }
                if (dayunxu == 1)
                {
                    labeltianshimao.Text = "天殇";
                    labeltianshisi.Text = "天使";
                }
                if (dayunhai == 1)
                {
                    labeltianshichen.Text = "天殇";
                    labeltianshiwu.Text = "天使";
                }
                if (dayunzi == 1)
                {
                    labeltianshisi.Text = "天殇";
                    labeltianshiwei.Text = "天使";
                }
                if (dayunchou == 1)
                {
                    labeltianshiwu.Text = "天殇";
                    labeltianshishen.Text = "天使";
                }

            }
            //天刑天姚
            if (jia == jia)
            {
                labeltianyaoyin.Text = "";
                labeltianyaomao.Text = "";
                labeltianyaochen.Text = "";
                labeltianyaosi.Text = "";
                labeltianyaowu.Text = "";
                labeltianyaowei.Text = "";
                labeltianyaoshen.Text = "";
                labeltianyaoyou.Text = "";
                labeltianyaoxu.Text = "";
                labeltianyaohai.Text = "";
                labeltianyaozi.Text = "";
                labeltianyaochou.Text = "";

                if (monthNL == 1)
                {
                    labeltianyaoyou.Text = "天刑";
                    labeltianyaochou.Text = "天姚";
                }
                if (monthNL == 2)
                {
                    labeltianyaoxu.Text = "天刑";
                    labeltianyaoyin.Text = "天姚";
                }
                if (monthNL == 3)
                {
                    labeltianyaohai.Text = "天刑";
                    labeltianyaomao.Text = "天姚";
                }
                if (monthNL == 4)
                {
                    labeltianyaozi.Text = "天刑";
                    labeltianyaochen.Text = "天姚";
                }
                if (monthNL == 5)
                {
                    labeltianyaochou.Text = "天刑";
                    labeltianyaosi.Text = "天姚";
                }
                if (monthNL == 6)
                {
                    labeltianyaoyin.Text = "天刑";
                    labeltianyaowu.Text = "天姚";
                }
                if (monthNL == 7)
                {
                    labeltianyaomao.Text = "天刑";
                    labeltianyaowei.Text = "天姚";
                }
                if (monthNL == 8)
                {
                    labeltianyaochen.Text = "天刑";
                    labeltianyaoshen.Text = "天姚";
                }
                if (monthNL == 9)
                {
                    labeltianyaosi.Text = "天刑";
                    labeltianyaoyou.Text = "天姚";
                }
                if (monthNL == 10)
                {
                    labeltianyaowu.Text = "天刑";
                    labeltianyaoxu.Text = "天姚";
                }
                if (monthNL == 11)
                {
                    labeltianyaowei.Text = "天刑";
                    labeltianyaohai.Text = "天姚";
                }
                if (monthNL == 12)
                {
                    labeltianyaoshen.Text = "天刑";
                    labeltianyaozi.Text = "天姚";
                }

            }
            //天哭天虚
            if (jia == jia)
            {
                labeltiankuyin.Text = "";
                labeltiankumao.Text = "";
                labeltiankuchen.Text = "";
                labeltiankusi.Text = "";
                labeltiankuwu.Text = "";
                labeltiankuwei.Text = "";
                labeltiankushen.Text = "";
                labeltiankuyou.Text = "";
                labeltiankuxu.Text = "";
                labeltiankuhai.Text = "";
                labeltiankuzi.Text = "";
                labeltiankuchou.Text = "";

                labeltianxuyin.Text = "";
                labeltianxumao.Text = "";
                labeltianxuchen.Text = "";
                labeltianxusi.Text = "";
                labeltianxuwu.Text = "";
                labeltianxuwei.Text = "";
                labeltianxushen.Text = "";
                labeltianxuyou.Text = "";
                labeltianxuxu.Text = "";
                labeltianxuhai.Text = "";
                labeltianxuzi.Text = "";
                labeltianxuchou.Text = "";

                if (ndz == zii)
                {
                    labeltianxuwu.Text = "天虚";
                    labeltiankuwu.Text = "天哭";
                }
                if (ndz == chou)
                {
                    labeltianxuwei.Text = "天虚";
                    labeltiankusi.Text = "天哭";
                }
                if (ndz == yin)
                {
                    labeltianxushen.Text = "天虚";
                    labeltiankuchen.Text = "天哭";
                }
                if (ndz == mao)
                {
                    labeltianxuyou.Text = "天虚";
                    labeltiankumao.Text = "天哭";
                }
                if (ndz == chen)
                {
                    labeltianxuxu.Text = "天虚";
                    labeltiankuyin.Text = "天哭";
                }
                if (ndz == sii)
                {
                    labeltianxuhai.Text = "天虚";
                    labeltiankuchou.Text = "天哭";
                }
                if (ndz == wuma)
                {
                    labeltianxuzi.Text = "天虚";
                    labeltiankuzi.Text = "天哭";
                }
                if (ndz == wei)
                {
                    labeltianxuchou.Text = "天虚";
                    labeltiankuhai.Text = "天哭";
                }
                if (ndz == shen)
                {
                    labeltianxuyin.Text = "天虚";
                    labeltiankuxu.Text = "天哭";
                }
                if (ndz == you)
                {
                    labeltianxumao.Text = "天虚";
                    labeltiankuyou.Text = "天哭";
                }
                if (ndz == xuu)
                {
                    labeltianxuchen.Text = "天虚";
                    labeltiankushen.Text = "天哭";
                }
                if (ndz == hai)
                {
                    labeltianxusi.Text = "天虚";
                    labeltiankuwei.Text = "天哭";
                }

            }
            //龙池凤阁
            if (jia == jia)
            {
                labellongchiyin.Text = "";
                labellongchimao.Text = "";
                labellongchichen.Text = "";
                labellongchisi.Text = "";
                labellongchiwu.Text = "";
                labellongchiwei.Text = "";
                labellongchishen.Text = "";
                labellongchiyou.Text = "";
                labellongchixu.Text = "";
                labellongchihai.Text = "";
                labellongchizi.Text = "";
                labellongchichou.Text = "";

                labelfenggeyin.Text = "";
                labelfenggemao.Text = "";
                labelfenggechen.Text = "";
                labelfenggesi.Text = "";
                labelfenggewu.Text = "";
                labelfenggewei.Text = "";
                labelfenggeshen.Text = "";
                labelfenggeyou.Text = "";
                labelfenggexu.Text = "";
                labelfenggehai.Text = "";
                labelfenggezi.Text = "";
                labelfenggechou.Text = "";

                if (ndz == zii)
                {
                    labelfenggexu.Text = "凤阁";
                    labellongchichen.Text = "龙池";
                }
                if (ndz == chou)
                {
                    labelfenggeyou.Text = "凤阁";
                    labellongchisi.Text = "龙池";
                }
                if (ndz == yin)
                {
                    labelfenggeshen.Text = "凤阁";
                    labellongchiwu.Text = "龙池";
                }
                if (ndz == mao)
                {
                    labelfenggewei.Text = "凤阁";
                    labellongchiwei.Text = "龙池";
                }
                if (ndz == chen)
                {
                    labelfenggewu.Text = "凤阁";
                    labellongchishen.Text = "龙池";
                }
                if (ndz == sii)
                {
                    labelfenggesi.Text = "凤阁";
                    labellongchiyou.Text = "龙池";
                }
                if (ndz == wuma)
                {
                    labelfenggechen.Text = "凤阁";
                    labellongchixu.Text = "龙池";
                }
                if (ndz == wei)
                {
                    labelfenggemao.Text = "凤阁";
                    labellongchihai.Text = "龙池";
                }
                if (ndz == shen)
                {
                    labelfenggeyin.Text = "凤阁";
                    labellongchizi.Text = "龙池";
                }
                if (ndz == you)
                {
                    labelfenggechou.Text = "凤阁";
                    labellongchichou.Text = "龙池";
                }
                if (ndz == xuu)
                {
                    labelfenggechou.Text = "凤阁";
                    labellongchichou.Text = "龙池";
                }
                if (ndz == hai)
                {
                    labelfenggezi.Text = "凤阁";
                    labellongchiyin.Text = "龙池";
                }

            }
            //台辅封诰
            if (jia == jia)
            {

                labeltaifuyin.Text = "";
                labeltaifumao.Text = "";
                labeltaifuchen.Text = "";
                labeltaifusi.Text = "";
                labeltaifuwu.Text = "";
                labeltaifuwei.Text = "";
                labeltaifushen.Text = "";
                labeltaifuyou.Text = "";
                labeltaifuxu.Text = "";
                labeltaifuhai.Text = "";
                labeltaifuzi.Text = "";
                labeltaifuchou.Text = "";

                if (sdz == zii)
                {
                    labeltaifuwu.Text = "台辅";
                    labeltaifuyin.Text = "封诰";
                }
                if (sdz == chou)
                {
                    labeltaifuwei.Text = "台辅";
                    labeltaifumao.Text = "封诰";
                }
                if (sdz == yin)
                {
                    labeltaifushen.Text = "台辅";
                    labeltaifuchen.Text = "封诰";
                }
                if (sdz == mao)
                {
                    labeltaifuyou.Text = "台辅";
                    labeltaifusi.Text = "封诰";
                }
                if (sdz == chen)
                {
                    labeltaifuxu.Text = "台辅";
                    labeltaifuwu.Text = "封诰";
                }
                if (sdz == sii)
                {
                    labeltaifuhai.Text = "台辅";
                    labeltaifuwei.Text = "封诰";
                }
                if (sdz == wuma)
                {
                    labeltaifuzi.Text = "台辅";
                    labeltaifushen.Text = "封诰";
                }
                if (sdz == wei)
                {
                    labeltaifuchou.Text = "台辅";
                    labeltaifuyou.Text = "封诰";
                }
                if (sdz == shen)
                {
                    labeltaifuyin.Text = "台辅";
                    labeltaifuxu.Text = "封诰";
                }
                if (sdz == you)
                {
                    labeltaifumao.Text = "台辅";
                    labeltaifuhai.Text = "封诰";
                }
                if (sdz == xuu)
                {
                    labeltaifuchen.Text = "台辅";
                    labeltaifuzi.Text = "封诰";
                }
                if (sdz == hai)
                {
                    labeltaifusi.Text = "台辅";
                    labeltaifuchou.Text = "封诰";
                }

            }
            //天官
            if (jia == jia)
            {
                labeltianguanyin.Text = "";
                labeltianguanmao.Text = "";
                labeltianguanchen.Text = "";
                labeltianguansi.Text = "";
                labeltianguanwu.Text = "";
                labeltianguanwei.Text = "";
                labeltianguanshen.Text = "";
                labeltianguanyou.Text = "";
                labeltianguanxu.Text = "";
                labeltianguanhai.Text = "";

                if (ntg == jia)
                {
                    labeltianguanwei.Text = "天官";
                }
                if (ntg == yii)
                {
                    labeltianguanchen.Text = "天官";
                }
                if (ntg == bing)
                {
                    labeltianguansi.Text = "天官";
                }
                if (ntg == ding)
                {
                    labeltianguanyin.Text = "天官";
                }
                if (ntg == wuu)
                {
                    labeltianguanmao.Text = "天官";
                }
                if (ntg == jii)
                {
                    labeltianguanyou.Text = "天官";
                }
                if (ntg == geng)
                {
                    labeltianguanhai.Text = "天官";
                }
                if (ntg == xin)
                {
                    labeltianguanyou.Text = "天官";
                }
                if (ntg == ren)
                {
                    labeltianguanxu.Text = "天官";
                }
                if (ntg == gui)
                {
                    labeltianguanwu.Text = "天官";
                }

            }
            //红鸾天喜
            if (jia == jia)
            {

                labelhongluantxyin.Text = "";
                labelhongluantxmao.Text = "";
                labelhongluantxchen.Text = "";
                labelhongluantxsi.Text = "";
                labelhongluantxwu.Text = "";
                labelhongluantxwei.Text = "";
                labelhongluantxshen.Text = "";
                labelhongluantxyou.Text = "";
                labelhongluantxxu.Text = "";
                labelhongluantxhai.Text = "";
                labelhongluantxzi.Text = "";
                labelhongluantxchou.Text = "";

                if (ndz == zii)
                {
                    labelhongluantxmao.Text = "红鸾";
                    labelhongluantxyou.Text = "天喜";
                }
                if (ndz == chou)
                {
                    labelhongluantxyin.Text = "红鸾";
                    labelhongluantxshen.Text = "天喜";
                }
                if (ndz == yin)
                {
                    labelhongluantxchou.Text = "红鸾";
                    labelhongluantxwei.Text = "天喜";
                }
                if (ndz == mao)
                {
                    labelhongluantxzi.Text = "红鸾";
                    labelhongluantxwu.Text = "天喜";
                }
                if (ndz == chen)
                {
                    labelhongluantxhai.Text = "红鸾";
                    labelhongluantxsi.Text = "天喜";
                }
                if (ndz == sii)
                {
                    labelhongluantxxu.Text = "红鸾";
                    labelhongluantxchen.Text = "天喜";
                }
                if (ndz == wuma)
                {
                    labelhongluantxyou.Text = "红鸾";
                    labelhongluantxmao.Text = "天喜";
                }
                if (ndz == wei)
                {
                    labelhongluantxshen.Text = "红鸾";
                    labelhongluantxyin.Text = "天喜";
                }
                if (ndz == shen)
                {
                    labelhongluantxwei.Text = "红鸾";
                    labelhongluantxchou.Text = "天喜";
                }
                if (ndz == you)
                {
                    labelhongluantxwu.Text = "红鸾";
                    labelhongluantxzi.Text = "天喜";
                }
                if (ndz == xuu)
                {
                    labelhongluantxsi.Text = "红鸾";
                    labelhongluantxhai.Text = "天喜";
                }
                if (ndz == hai)
                {
                    labelhongluantxchen.Text = "红鸾";
                    labelhongluantxxu.Text = "天喜";
                }

            }
            //孤辰寡宿
            if (jia == jia)
            {
                labelguchenguasuyin.Text = "";
                labelguchenguasusi.Text = "";
                labelguchenguasushen.Text = "";
                labelguchenguasuhai.Text = "";
                labelguchenguasuchen.Text = "";
                labelguchenguasuxu.Text = "";
                labelguchenguasuchou.Text = "";
                labelguchenguasuwei.Text = "";

                if (ndz == yin || ndz == wuma || ndz == xuu)
                {
                    labelguchenguasusi.Text = "孤辰";
                    labelguchenguasuchou.Text = "寡宿";
                }
                if (ndz == sii || ndz == you || ndz == chou)
                {
                    labelguchenguasushen.Text = "孤辰";
                    labelguchenguasuchen.Text = "寡宿";
                }
                if (ndz == shen || ndz == zii || ndz == chen)
                {
                    labelguchenguasuhai.Text = "孤辰";
                    labelguchenguasuwei.Text = "寡宿";
                }
                if (ndz == hai || ndz == mao || ndz == wei)
                {
                    labelguchenguasuyin.Text = "孤辰";
                    labelguchenguasuxu.Text = "寡宿";
                }
            }
            //蜚廉
            if (jia == jia)
            {
                labelfeilianyin.Text = "";
                labelfeilianmao.Text = "";
                labelfeilianchen.Text = "";
                labelfeiliansi.Text = "";
                labelfeilianwu.Text = "";
                labelfeilianwei.Text = "";
                labelfeilianshen.Text = "";
                labelfeilianyou.Text = "";
                labelfeilianxu.Text = "";
                labelfeilianhai.Text = "";
                labelfeilianzi.Text = "";
                labelfeilianchou.Text = "";

                if (ndz == zii)
                {
                    labelfeilianshen.Text = "蜚廉";
                }
                if (ndz == chou)
                {
                    labelfeilianyou.Text = "蜚廉";
                }
                if (ndz == yin)
                {
                    labelfeilianxu.Text = "蜚廉";
                }
                if (ndz == mao)
                {
                    labelfeiliansi.Text = "蜚廉";
                }
                if (ndz == chen)
                {
                    labelfeilianwu.Text = "蜚廉";
                }
                if (ndz == sii)
                {
                    labelfeilianwei.Text = "蜚廉";
                }
                if (ndz == wuma)
                {
                    labelfeilianyin.Text = "蜚廉";
                }
                if (ndz == wei)
                {
                    labelfeilianmao.Text = "蜚廉";
                }
                if (ndz == shen)
                {
                    labelfeilianchen.Text = "蜚廉";
                }
                if (ndz == wei)
                {
                    labelfeilianhai.Text = "蜚廉";
                }
                if (ndz == xuu)
                {
                    labelfeilianzi.Text = "蜚廉";
                }
                if (ndz == hai)
                {
                    labelfeilianchou.Text = "蜚廉";
                }

            }
            //破碎
            if (jia == jia)
            {
                labelpuosuisi.Text = "";
                labelpuosuiyou.Text = "";
                labelpuosuichou.Text = "";

                if (ndz == zii || ndz == wuma || ndz == mao || ndz == you)
                {
                    labelpuosuisi.Text = "破碎";
                }
                if (ndz == yin || ndz == shen || ndz == sii || ndz == hai)
                {
                    labelpuosuiyou.Text = "破碎";
                }
                if (ndz == xuu || ndz == chen || ndz == wei || ndz == chou)
                {
                    labelpuosuichou.Text = "破碎";
                }

            }
            //截空
            if (jia == jia)
            {
                labeljiekongyin.Text = "";
                labeljiekongmao.Text = "";
                labeljiekongchen.Text = "";
                labeljiekongsi.Text = "";
                labeljiekongwu.Text = "";
                labeljiekongwei.Text = "";
                labeljiekongshen.Text = "";
                labeljiekongyou.Text = "";
                labeljiekongxu.Text = "";
                labeljiekonghai.Text = "";
                labeljiekongzi.Text = "";
                labeljiekongchou.Text = "";

                if (ntg == jia || ntg == jii)
                {
                    labeljiekongshen.Text = "截空";
                    labeljiekongyou.Text = "截空";
                }
                if (ntg == yii || ntg == geng)
                {
                    labeljiekongwu.Text = "截空";
                    labeljiekongwei.Text = "截空";
                }
                if (ntg == bing || ntg == xin)
                {
                    labeljiekongchen.Text = "截空";
                    labeljiekongsi.Text = "截空";
                }
                if (ntg == ding || ntg == ren)
                {
                    labeljiekongyin.Text = "截空";
                    labeljiekongmao.Text = "截空";
                }
                if (ntg == wuu || ntg == gui)
                {
                    labeljiekongzi.Text = "截空";
                    labeljiekongchou.Text = "截空";
                }

            }
            //天才天寿
            if (jia == jia)
            {
                labeltiancaiyin.Text = "";
                labeltiancaimao.Text = "";
                labeltiancaichen.Text = "";
                labeltiancaisi.Text = "";
                labeltiancaiwu.Text = "";
                labeltiancaiwei.Text = "";
                labeltiancaishen.Text = "";
                labeltiancaiyou.Text = "";
                labeltiancaixu.Text = "";
                labeltiancaihai.Text = "";
                labeltiancaizi.Text = "";
                labeltiancaichou.Text = "";

                labeltianshouyin.Text = "";
                labeltianshoumao.Text = "";
                labeltianshouchen.Text = "";
                labeltianshousi.Text = "";
                labeltianshouwu.Text = "";
                labeltianshouwei.Text = "";
                labeltianshoushen.Text = "";
                labeltianshouyou.Text = "";
                labeltianshouxu.Text = "";
                labeltianshouhai.Text = "";
                labeltianshouzi.Text = "";
                labeltianshouchou.Text = "";

                int minggong = 0;
                int shen2gong = 0;

                if (dayunzi == 1)
                {
                    minggong = 1;
                }
                if (dayunchou == 1)
                {
                    minggong = 2;
                }
                if (dayunyin == 1)
                {
                    minggong = 3;
                }
                if (dayunmao == 1)
                {
                    minggong = 4;
                }
                if (dayunchen == 1)
                {
                    minggong = 5;
                }
                if (dayunsi == 1)
                {
                    minggong = 6;
                }
                if (dayunwu == 1)
                {
                    minggong = 7;
                }
                if (dayunwei == 1)
                {
                    minggong = 8;
                }
                if (dayunshen == 1)
                {
                    minggong = 9;
                }
                if (dayunyou == 1)
                {
                    minggong = 10;
                }
                if (dayunxu == 1)
                {
                    minggong = 11;
                }
                if (dayunhai == 1)
                {
                    minggong = 12;
                }

                if (shengongzi == 1)
                {
                    shen2gong = 1;
                }
                if (shengongchou == 1)
                {
                    shen2gong = 2;
                }
                if (shengongyin == 1)
                {
                    shen2gong = 3;
                }
                if (shengongmao == 1)
                {
                    shen2gong = 4;
                }
                if (shengongchen == 1)
                {
                    shen2gong = 5;
                }
                if (shengongsi == 1)
                {
                    shen2gong = 6;
                }
                if (shengongwu == 1)
                {
                    shen2gong = 7;
                }
                if (shengongwei == 1)
                {
                    shen2gong = 8;
                }
                if (shengongshen == 1)
                {
                    shen2gong = 9;
                }
                if (shengongyou == 1)
                {
                    shen2gong = 10;
                }
                if (shengongxu == 1)
                {
                    shen2gong = 11;
                }
                if (shengonghai == 1)
                {
                    shen2gong = 12;
                }

                if (ndz == zii)
                {
                    minggong += 1;
                    shen2gong += 1;
                }
                if (ndz == chou)
                {
                    minggong += 2;
                    shen2gong += 2;
                }
                if (ndz == yin)
                {
                    minggong += 3;
                    shen2gong += 3;
                }
                if (ndz == mao)
                {
                    minggong += 4;
                    shen2gong += 4;
                }
                if (ndz == chen)
                {
                    minggong += 5;
                    shen2gong += 5;
                }
                if (ndz == sii)
                {
                    minggong += 6;
                    shen2gong += 6;
                }
                if (ndz == wuma)
                {
                    minggong += 7;
                    shen2gong += 7;
                }
                if (ndz == wei)
                {
                    minggong += 8;
                    shen2gong += 8;
                }
                if (ndz == shen)
                {
                    minggong += 9;
                    shen2gong += 9;
                }
                if (ndz == you)
                {
                    minggong += 10;
                    shen2gong += 10;
                }
                if (ndz == xuu)
                {
                    minggong += 11;
                    shen2gong += 11;
                }
                if (ndz == hai)
                {
                    minggong += 12;
                    shen2gong += 12;
                }
                if (minggong > 12)
                {
                    minggong -= 12;
                }
                if (shen2gong > 12)
                {
                    shen2gong -= 12;
                }
                if (minggong == 1)
                {
                    labeltiancaizi.Text = "天才";
                }
                if (minggong == 2)
                {
                    labeltiancaichou.Text = "天才";
                }
                if (minggong == 3)
                {
                    labeltiancaiyin.Text = "天才";
                }
                if (minggong == 4)
                {
                    labeltiancaimao.Text = "天才";
                }
                if (minggong == 5)
                {
                    labeltiancaichen.Text = "天才";
                }
                if (minggong == 6)
                {
                    labeltiancaisi.Text = "天才";
                }
                if (minggong == 7)
                {
                    labeltiancaiwu.Text = "天才";
                }
                if (minggong == 8)
                {
                    labeltiancaiwei.Text = "天才";
                }
                if (minggong == 9)
                {
                    labeltiancaishen.Text = "天才";
                }
                if (minggong == 10)
                {
                    labeltiancaiyou.Text = "天才";
                }
                if (minggong == 11)
                {
                    labeltiancaixu.Text = "天才";
                }
                if (minggong == 12)
                {
                    labeltiancaihai.Text = "天才";
                }
                if (shen2gong == 1)
                {
                    labeltianshouzi.Text = "天寿";
                }
                if (shen2gong == 2)
                {
                    labeltianshouchou.Text = "天寿";
                }
                if (shen2gong == 3)
                {
                    labeltianshouyin.Text = "天寿";
                }
                if (shen2gong == 4)
                {
                    labeltianshoumao.Text = "天寿";
                }
                if (shen2gong == 5)
                {
                    labeltianshouchen.Text = "天寿";
                }
                if (shen2gong == 6)
                {
                    labeltianshousi.Text = "天寿";
                }
                if (shen2gong == 7)
                {
                    labeltianshouwu.Text = "天寿";
                }
                if (shen2gong == 8)
                {
                    labeltianshouwei.Text = "天寿";
                }
                if (shen2gong == 9)
                {
                    labeltianshoushen.Text = "天寿";
                }
                if (shen2gong == 10)
                {
                    labeltianshouyou.Text = "天寿";
                }
                if (shen2gong == 11)
                {
                    labeltianshouxu.Text = "天寿";
                }
                if (shen2gong == 12)
                {
                    labeltianshouhai.Text = "天寿";
                }

            }
            //大运十二长生
            if (jia == jia)
            {
                if (radioButtonll.Checked)
                {
                    if (ntg == jia || ntg == wuu || ntg == ren || ntg == bing || ntg == geng)
                    {
                        if (ytg == jia)
                        {
                            dyss10 = yii;
                            dyss20 = bing;
                            dyss30 = ding;
                            dyss40 = wuu;
                            dyss50 = jii;
                            dyss60 = geng;
                            dyss70 = xin;
                            dyss80 = ren;
                            dyss90 = gui;
                            dyss100 = jia;
                            dyss110 = yii;
                            dyss120 = bing;
                        }
                        if (ytg == yii)
                        {
                            dyss10 = bing;
                            dyss20 = ding;
                            dyss30 = wuu;
                            dyss40 = jii;
                            dyss50 = geng;
                            dyss60 = xin;
                            dyss70 = ren;
                            dyss80 = gui;
                            dyss90 = jia;
                            dyss100 = yii;
                            dyss110 = bing;
                            dyss120 = ding;
                        }
                        if (ytg == bing)
                        {
                            dyss10 = ding;
                            dyss20 = wuu;
                            dyss30 = jii;
                            dyss40 = geng;
                            dyss50 = xin;
                            dyss60 = ren;
                            dyss70 = gui;
                            dyss80 = jia;
                            dyss90 = yii;
                            dyss100 = bing;
                            dyss110 = ding;
                            dyss120 = wuu;
                        }
                        if (ytg == ding)
                        {
                            dyss10 = wuu;
                            dyss20 = jii;
                            dyss30 = geng;
                            dyss40 = xin;
                            dyss50 = ren;
                            dyss60 = gui;
                            dyss70 = jia;
                            dyss80 = yii;
                            dyss90 = bing;
                            dyss100 = ding;
                            dyss110 = wuu;
                            dyss120 = jii;
                        }
                        if (ytg == wuu)
                        {
                            dyss10 = jii;
                            dyss20 = geng;
                            dyss30 = xin;
                            dyss40 = ren;
                            dyss50 = gui;
                            dyss60 = jia;
                            dyss70 = yii;
                            dyss80 = bing;
                            dyss90 = ding;
                            dyss100 = wuu;
                            dyss110 = jii;
                            dyss120 = geng;
                        }
                        if (ytg == jii)
                        {
                            dyss10 = geng;
                            dyss20 = xin;
                            dyss30 = ren;
                            dyss40 = gui;
                            dyss50 = jia;
                            dyss60 = yii;
                            dyss70 = bing;
                            dyss80 = ding;
                            dyss90 = wuu;
                            dyss100 = jii;
                            dyss110 = geng;
                            dyss120 = xin;
                        }
                        if (ytg == geng)
                        {
                            dyss10 = xin;
                            dyss20 = ren;
                            dyss30 = gui;
                            dyss40 = jia;
                            dyss50 = yii;
                            dyss60 = bing;
                            dyss70 = ding;
                            dyss80 = wuu;
                            dyss90 = jii;
                            dyss100 = geng;
                            dyss110 = xin;
                            dyss120 = ren;
                        }
                        if (ytg == xin)
                        {
                            dyss10 = ren;
                            dyss20 = gui;
                            dyss30 = jia;
                            dyss40 = yii;
                            dyss50 = bing;
                            dyss60 = ding;
                            dyss70 = wuu;
                            dyss80 = jii;
                            dyss90 = geng;
                            dyss100 = xin;
                            dyss110 = ren;
                            dyss120 = gui;
                        }
                        if (ytg == ren)
                        {
                            dyss10 = gui;
                            dyss20 = jia;
                            dyss30 = yii;
                            dyss40 = bing;
                            dyss50 = ding;
                            dyss60 = wuu;
                            dyss70 = jii;
                            dyss80 = geng;
                            dyss90 = xin;
                            dyss100 = ren;
                            dyss110 = gui;
                            dyss120 = jia;
                        }
                        if (ytg == gui)
                        {
                            dyss10 = jia;
                            dyss20 = yii;
                            dyss30 = bing;
                            dyss40 = ding;
                            dyss50 = wuu;
                            dyss60 = jii;
                            dyss70 = geng;
                            dyss80 = xin;
                            dyss90 = ren;
                            dyss100 = gui;
                            dyss110 = jia;
                            dyss120 = yii;
                        }


                        if (ydz == yin)
                        {
                            dy10 = mao;
                            dy20 = chen;
                            dy30 = sii;
                            dy40 = wuma;
                            dy50 = wei;
                            dy60 = shen;
                            dy70 = you;
                            dy80 = xuu;
                            dy90 = hai;
                            dy100 = zii;
                            dy110 = chou;
                            dy120 = yin;

                        }
                        if (ydz == mao)
                        {
                            dy10 = chen;
                            dy20 = sii;
                            dy30 = wuma;
                            dy40 = wei;
                            dy50 = shen;
                            dy60 = you;
                            dy70 = xuu;
                            dy80 = hai;
                            dy90 = zii;
                            dy100 = chou;
                            dy110 = yin;
                            dy120 = mao;

                        }
                        if (ydz == chen)
                        {
                            dy10 = sii;
                            dy20 = wuma;
                            dy30 = wei;
                            dy40 = shen;
                            dy50 = you;
                            dy60 = xuu;
                            dy70 = hai;
                            dy80 = zii;
                            dy90 = chou;
                            dy100 = yin;
                            dy110 = mao;
                            dy120 = chen;

                        }
                        if (ydz == sii)
                        {
                            dy10 = wuma;
                            dy20 = wei;
                            dy30 = shen;
                            dy40 = you;
                            dy50 = xuu;
                            dy60 = hai;
                            dy70 = zii;
                            dy80 = chou;
                            dy90 = yin;
                            dy100 = mao;
                            dy110 = chen;
                            dy120 = sii;

                        }
                        if (ydz == wuma)
                        {
                            dy10 = wei;
                            dy20 = shen;
                            dy30 = you;
                            dy40 = xuu;
                            dy50 = hai;
                            dy60 = zii;
                            dy70 = chou;
                            dy80 = yin;
                            dy90 = mao;
                            dy100 = chen;
                            dy110 = sii;
                            dy120 = wuma;

                        }
                        if (ydz == wei)
                        {
                            dy10 = shen;
                            dy20 = you;
                            dy30 = xuu;
                            dy40 = hai;
                            dy50 = zii;
                            dy60 = chou;
                            dy70 = yin;
                            dy80 = mao;
                            dy90 = chen;
                            dy100 = sii;
                            dy110 = wuma;
                            dy120 = wei;

                        }
                        if (ydz == shen)
                        {
                            dy10 = you;
                            dy20 = xuu;
                            dy30 = hai;
                            dy40 = zii;
                            dy50 = chou;
                            dy60 = yin;
                            dy70 = mao;
                            dy80 = chen;
                            dy90 = sii;
                            dy100 = wuma;
                            dy110 = wei;
                            dy120 = shen;

                        }
                        if (ydz == you)
                        {
                            dy10 = xuu;
                            dy20 = hai;
                            dy30 = zii;
                            dy40 = chou;
                            dy50 = yin;
                            dy60 = mao;
                            dy70 = chen;
                            dy80 = sii;
                            dy90 = wuma;
                            dy100 = wei;
                            dy110 = shen;
                            dy120 = you;

                        }
                        if (ydz == xuu)
                        {
                            dy10 = hai;
                            dy20 = zii;
                            dy30 = chou;
                            dy40 = yin;
                            dy50 = mao;
                            dy60 = chen;
                            dy70 = sii;
                            dy80 = wuma;
                            dy90 = wei;
                            dy100 = shen;
                            dy110 = you;
                            dy120 = xuu;

                        }
                        if (ydz == hai)
                        {
                            dy10 = zii;
                            dy20 = chou;
                            dy30 = yin;
                            dy40 = mao;
                            dy50 = chen;
                            dy60 = sii;
                            dy70 = wuma;
                            dy80 = wei;
                            dy90 = shen;
                            dy100 = you;
                            dy110 = xuu;
                            dy120 = hai;

                        }
                        if (ydz == zii)
                        {
                            dy10 = chou;
                            dy20 = yin;
                            dy30 = mao;
                            dy40 = chen;
                            dy50 = sii;
                            dy60 = wuma;
                            dy70 = wei;
                            dy80 = shen;
                            dy90 = you;
                            dy100 = xuu;
                            dy110 = hai;
                            dy120 = zii;

                        }
                        if (ydz == chou)
                        {
                            dy10 = yin;
                            dy20 = mao;
                            dy30 = chen;
                            dy40 = sii;
                            dy50 = wuma;
                            dy60 = wei;
                            dy70 = shen;
                            dy80 = you;
                            dy90 = xuu;
                            dy100 = hai;
                            dy110 = zii;
                            dy120 = chou;

                        }

                    }
                    if (ntg == yii || ntg == jii || ntg == gui || ntg == ding || ntg == xin)
                    {
                        if (ytg == jia)
                        {
                            dyss10 = gui;
                            dyss20 = ren;
                            dyss30 = xin;
                            dyss40 = geng;
                            dyss50 = jii;
                            dyss60 = wuu;
                            dyss70 = ding;
                            dyss80 = bing;
                            dyss90 = yii;
                            dyss100 = jia;
                            dyss110 = gui;
                            dyss120 = ren;
                        }
                        if (ytg == gui)
                        {
                            dyss10 = ren;
                            dyss20 = xin;
                            dyss30 = geng;
                            dyss40 = jii;
                            dyss50 = wuu;
                            dyss60 = ding;
                            dyss70 = bing;
                            dyss80 = yii;
                            dyss90 = jia;
                            dyss100 = gui;
                            dyss110 = ren;
                            dyss120 = xin;
                        }
                        if (ytg == ren)
                        {
                            dyss10 = xin;
                            dyss20 = geng;
                            dyss30 = jii;
                            dyss40 = wuu;
                            dyss50 = ding;
                            dyss60 = bing;
                            dyss70 = yii;
                            dyss80 = jia;
                            dyss90 = gui;
                            dyss100 = ren;
                            dyss110 = xin;
                            dyss120 = geng;
                        }
                        if (ytg == xin)
                        {
                            dyss10 = geng;
                            dyss20 = jii;
                            dyss30 = wuu;
                            dyss40 = ding;
                            dyss50 = bing;
                            dyss60 = yii;
                            dyss70 = jia;
                            dyss80 = gui;
                            dyss90 = ren;
                            dyss100 = xin;
                            dyss110 = geng;
                            dyss120 = jii;
                        }
                        if (ytg == geng)
                        {
                            dyss10 = jii;
                            dyss20 = wuu;
                            dyss30 = ding;
                            dyss40 = bing;
                            dyss50 = yii;
                            dyss60 = jia;
                            dyss70 = gui;
                            dyss80 = ren;
                            dyss90 = xin;
                            dyss100 = geng;
                            dyss110 = jii;
                            dyss120 = wuu;
                        }
                        if (ytg == jii)
                        {
                            dyss10 = wuu;
                            dyss20 = ding;
                            dyss30 = bing;
                            dyss40 = yii;
                            dyss50 = jia;
                            dyss60 = gui;
                            dyss70 = ren;
                            dyss80 = xin;
                            dyss90 = geng;
                            dyss100 = jii;
                            dyss110 = wuu;
                            dyss120 = ding;
                        }
                        if (ytg == wuu)
                        {
                            dyss10 = ding;
                            dyss20 = bing;
                            dyss30 = yii;
                            dyss40 = jia;
                            dyss50 = gui;
                            dyss60 = ren;
                            dyss70 = xin;
                            dyss80 = geng;
                            dyss90 = jii;
                            dyss100 = wuu;
                            dyss110 = ding;
                            dyss120 = bing;
                        }
                        if (ytg == ding)
                        {
                            dyss10 = bing;
                            dyss20 = yii;
                            dyss30 = jia;
                            dyss40 = gui;
                            dyss50 = ren;
                            dyss60 = xin;
                            dyss70 = geng;
                            dyss80 = jii;
                            dyss90 = wuu;
                            dyss100 = ding;
                            dyss110 = bing;
                            dyss120 = jii;
                        }
                        if (ytg == bing)
                        {
                            dyss10 = yii;
                            dyss20 = jia;
                            dyss30 = gui;
                            dyss40 = ren;
                            dyss50 = xin;
                            dyss60 = geng;
                            dyss70 = jii;
                            dyss80 = wuu;
                            dyss90 = ding;
                            dyss100 = bing;
                            dyss110 = jii;
                            dyss120 = wuu;
                        }
                        if (ytg == yii)
                        {
                            dyss10 = jia;
                            dyss20 = gui;
                            dyss30 = ren;
                            dyss40 = xin;
                            dyss50 = geng;
                            dyss60 = jii;
                            dyss70 = wuu;
                            dyss80 = ding;
                            dyss90 = bing;
                            dyss100 = jii;
                            dyss110 = wuu;
                            dyss120 = ding;
                        }


                        if (ydz == yin)
                        {
                            dy10 = chou;
                            dy20 = zii;
                            dy30 = hai;
                            dy40 = xuu;
                            dy50 = you;
                            dy60 = shen;
                            dy70 = wei;
                            dy80 = wuma;
                            dy90 = sii;
                            dy100 = chen;
                            dy110 = mao;
                            dy120 = yin;

                        }
                        if (ydz == mao)
                        {
                            dy10 = yin;
                            dy20 = chou;
                            dy30 = zii;
                            dy40 = hai;
                            dy50 = xuu;
                            dy60 = you;
                            dy70 = shen;
                            dy80 = wei;
                            dy90 = wuma;
                            dy100 = sii;
                            dy110 = chen;
                            dy120 = mao;

                        }
                        if (ydz == chen)
                        {
                            dy10 = mao;
                            dy20 = yin;
                            dy30 = chou;
                            dy40 = zii;
                            dy50 = hai;
                            dy60 = xuu;
                            dy70 = you;
                            dy80 = shen;
                            dy90 = wei;
                            dy100 = wuma;
                            dy110 = sii;
                            dy120 = chen;

                        }
                        if (ydz == sii)
                        {
                            dy10 = chen;
                            dy20 = mao;
                            dy30 = yin;
                            dy40 = chou;
                            dy50 = zii;
                            dy60 = hai;
                            dy70 = xuu;
                            dy80 = you;
                            dy90 = shen;
                            dy100 = wei;
                            dy110 = wuma;
                            dy120 = sii;

                        }
                        if (ydz == wuma)
                        {
                            dy10 = sii;
                            dy20 = chen;
                            dy30 = mao;
                            dy40 = yin;
                            dy50 = chou;
                            dy60 = zii;
                            dy70 = hai;
                            dy80 = xuu;
                            dy90 = you;
                            dy100 = shen;
                            dy110 = wei;
                            dy120 = wuma;

                        }
                        if (ydz == wei)
                        {
                            dy10 = wuma;
                            dy20 = sii;
                            dy30 = chen;
                            dy40 = mao;
                            dy50 = yin;
                            dy60 = chou;
                            dy70 = zii;
                            dy80 = hai;
                            dy90 = xuu;
                            dy100 = you;
                            dy110 = shen;
                            dy120 = wei;

                        }
                        if (ydz == shen)
                        {
                            dy10 = wei;
                            dy20 = wuma;
                            dy30 = sii;
                            dy40 = chen;
                            dy50 = mao;
                            dy60 = yin;
                            dy70 = chou;
                            dy80 = zii;
                            dy90 = hai;
                            dy100 = xuu;
                            dy110 = you;
                            dy120 = shen;

                        }
                        if (ydz == you)
                        {
                            dy10 = shen;
                            dy20 = wei;
                            dy30 = wuma;
                            dy40 = sii;
                            dy50 = chen;
                            dy60 = mao;
                            dy70 = yin;
                            dy80 = chou;
                            dy90 = zii;
                            dy100 = hai;
                            dy110 = xuu;
                            dy120 = you;

                        }
                        if (ydz == xuu)
                        {
                            dy10 = you;
                            dy20 = shen;
                            dy30 = wei;
                            dy40 = wuma;
                            dy50 = sii;
                            dy60 = chen;
                            dy70 = mao;
                            dy80 = yin;
                            dy90 = chou;
                            dy100 = zii;
                            dy110 = hai;
                            dy120 = xuu;

                        }
                        if (ydz == hai)
                        {
                            dy10 = xuu;
                            dy20 = you;
                            dy30 = shen;
                            dy40 = wei;
                            dy50 = wuma;
                            dy60 = sii;
                            dy70 = chen;
                            dy80 = mao;
                            dy90 = yin;
                            dy100 = chou;
                            dy110 = zii;
                            dy120 = hai;

                        }
                        if (ydz == zii)
                        {
                            dy10 = hai;
                            dy20 = xuu;
                            dy30 = you;
                            dy40 = shen;
                            dy50 = wei;
                            dy60 = wuma;
                            dy70 = sii;
                            dy80 = chen;
                            dy90 = mao;
                            dy100 = yin;
                            dy110 = chou;
                            dy120 = zii;

                        }
                        if (ydz == chou)
                        {
                            dy10 = zii;
                            dy20 = hai;
                            dy30 = xuu;
                            dy40 = you;
                            dy50 = shen;
                            dy60 = wei;
                            dy70 = wuma;
                            dy80 = sii;
                            dy90 = chen;
                            dy100 = mao;
                            dy110 = yin;
                            dy120 = chou;

                        }

                    }
                }
                if (radioButtonvv.Checked)
                {
                    if (ntg == yii || ntg == jii || ntg == gui || ntg == ding || ntg == xin)
                    {
                        if (ytg == jia)
                        {
                            dyss10 = yii;
                            dyss20 = bing;
                            dyss30 = ding;
                            dyss40 = wuu;
                            dyss50 = jii;
                            dyss60 = geng;
                            dyss70 = xin;
                            dyss80 = ren;
                            dyss90 = gui;
                            dyss100 = jia;
                            dyss110 = yii;
                            dyss120 = bing;
                        }
                        if (ytg == yii)
                        {
                            dyss10 = bing;
                            dyss20 = ding;
                            dyss30 = wuu;
                            dyss40 = jii;
                            dyss50 = geng;
                            dyss60 = xin;
                            dyss70 = ren;
                            dyss80 = gui;
                            dyss90 = jia;
                            dyss100 = yii;
                            dyss110 = bing;
                            dyss120 = ding;
                        }
                        if (ytg == bing)
                        {
                            dyss10 = ding;
                            dyss20 = wuu;
                            dyss30 = jii;
                            dyss40 = geng;
                            dyss50 = xin;
                            dyss60 = ren;
                            dyss70 = gui;
                            dyss80 = jia;
                            dyss90 = yii;
                            dyss100 = bing;
                            dyss110 = ding;
                            dyss120 = wuu;
                        }
                        if (ytg == ding)
                        {
                            dyss10 = wuu;
                            dyss20 = jii;
                            dyss30 = geng;
                            dyss40 = xin;
                            dyss50 = ren;
                            dyss60 = gui;
                            dyss70 = jia;
                            dyss80 = yii;
                            dyss90 = bing;
                            dyss100 = ding;
                            dyss110 = wuu;
                            dyss120 = jii;
                        }
                        if (ytg == wuu)
                        {
                            dyss10 = jii;
                            dyss20 = geng;
                            dyss30 = xin;
                            dyss40 = ren;
                            dyss50 = gui;
                            dyss60 = jia;
                            dyss70 = yii;
                            dyss80 = bing;
                            dyss90 = ding;
                            dyss100 = wuu;
                            dyss110 = jii;
                            dyss120 = geng;
                        }
                        if (ytg == jii)
                        {
                            dyss10 = geng;
                            dyss20 = xin;
                            dyss30 = ren;
                            dyss40 = gui;
                            dyss50 = jia;
                            dyss60 = yii;
                            dyss70 = bing;
                            dyss80 = ding;
                            dyss90 = wuu;
                            dyss100 = jii;
                            dyss110 = geng;
                            dyss120 = xin;
                        }
                        if (ytg == geng)
                        {
                            dyss10 = xin;
                            dyss20 = ren;
                            dyss30 = gui;
                            dyss40 = jia;
                            dyss50 = yii;
                            dyss60 = bing;
                            dyss70 = ding;
                            dyss80 = wuu;
                            dyss90 = jii;
                            dyss100 = geng;
                            dyss110 = xin;
                            dyss120 = ren;
                        }
                        if (ytg == xin)
                        {
                            dyss10 = ren;
                            dyss20 = gui;
                            dyss30 = jia;
                            dyss40 = yii;
                            dyss50 = bing;
                            dyss60 = ding;
                            dyss70 = wuu;
                            dyss80 = jii;
                            dyss90 = geng;
                            dyss100 = xin;
                            dyss110 = ren;
                            dyss120 = gui;
                        }
                        if (ytg == ren)
                        {
                            dyss10 = gui;
                            dyss20 = jia;
                            dyss30 = yii;
                            dyss40 = bing;
                            dyss50 = ding;
                            dyss60 = wuu;
                            dyss70 = jii;
                            dyss80 = geng;
                            dyss90 = xin;
                            dyss100 = ren;
                            dyss110 = gui;
                            dyss120 = jia;
                        }
                        if (ytg == gui)
                        {
                            dyss10 = jia;
                            dyss20 = yii;
                            dyss30 = bing;
                            dyss40 = ding;
                            dyss50 = wuu;
                            dyss60 = jii;
                            dyss70 = geng;
                            dyss80 = xin;
                            dyss90 = ren;
                            dyss100 = gui;
                            dyss110 = jia;
                            dyss120 = yii;
                        }


                        if (ydz == yin)
                        {
                            dy10 = mao;
                            dy20 = chen;
                            dy30 = sii;
                            dy40 = wuma;
                            dy50 = wei;
                            dy60 = shen;
                            dy70 = you;
                            dy80 = xuu;
                            dy90 = hai;
                            dy100 = zii;
                            dy110 = chou;
                            dy120 = yin;

                        }
                        if (ydz == mao)
                        {
                            dy10 = chen;
                            dy20 = sii;
                            dy30 = wuma;
                            dy40 = wei;
                            dy50 = shen;
                            dy60 = you;
                            dy70 = xuu;
                            dy80 = hai;
                            dy90 = zii;
                            dy100 = chou;
                            dy110 = yin;
                            dy120 = mao;

                        }
                        if (ydz == chen)
                        {
                            dy10 = sii;
                            dy20 = wuma;
                            dy30 = wei;
                            dy40 = shen;
                            dy50 = you;
                            dy60 = xuu;
                            dy70 = hai;
                            dy80 = zii;
                            dy90 = chou;
                            dy100 = yin;
                            dy110 = mao;
                            dy120 = chen;

                        }
                        if (ydz == sii)
                        {
                            dy10 = wuma;
                            dy20 = wei;
                            dy30 = shen;
                            dy40 = you;
                            dy50 = xuu;
                            dy60 = hai;
                            dy70 = zii;
                            dy80 = chou;
                            dy90 = yin;
                            dy100 = mao;
                            dy110 = chen;
                            dy120 = sii;

                        }
                        if (ydz == wuma)
                        {
                            dy10 = wei;
                            dy20 = shen;
                            dy30 = you;
                            dy40 = xuu;
                            dy50 = hai;
                            dy60 = zii;
                            dy70 = chou;
                            dy80 = yin;
                            dy90 = mao;
                            dy100 = chen;
                            dy110 = sii;
                            dy120 = wuma;

                        }
                        if (ydz == wei)
                        {
                            dy10 = shen;
                            dy20 = you;
                            dy30 = xuu;
                            dy40 = hai;
                            dy50 = zii;
                            dy60 = chou;
                            dy70 = yin;
                            dy80 = mao;
                            dy90 = chen;
                            dy100 = sii;
                            dy110 = wuma;
                            dy120 = wei;

                        }
                        if (ydz == shen)
                        {
                            dy10 = you;
                            dy20 = xuu;
                            dy30 = hai;
                            dy40 = zii;
                            dy50 = chou;
                            dy60 = yin;
                            dy70 = mao;
                            dy80 = chen;
                            dy90 = sii;
                            dy100 = wuma;
                            dy110 = wei;
                            dy120 = shen;

                        }
                        if (ydz == you)
                        {
                            dy10 = xuu;
                            dy20 = hai;
                            dy30 = zii;
                            dy40 = chou;
                            dy50 = yin;
                            dy60 = mao;
                            dy70 = chen;
                            dy80 = sii;
                            dy90 = wuma;
                            dy100 = wei;
                            dy110 = shen;
                            dy120 = you;

                        }
                        if (ydz == xuu)
                        {
                            dy10 = hai;
                            dy20 = zii;
                            dy30 = chou;
                            dy40 = yin;
                            dy50 = mao;
                            dy60 = chen;
                            dy70 = sii;
                            dy80 = wuma;
                            dy90 = wei;
                            dy100 = shen;
                            dy110 = you;
                            dy120 = xuu;

                        }
                        if (ydz == hai)
                        {
                            dy10 = zii;
                            dy20 = chou;
                            dy30 = yin;
                            dy40 = mao;
                            dy50 = chen;
                            dy60 = sii;
                            dy70 = wuma;
                            dy80 = wei;
                            dy90 = shen;
                            dy100 = you;
                            dy110 = xuu;
                            dy120 = hai;

                        }
                        if (ydz == zii)
                        {
                            dy10 = chou;
                            dy20 = yin;
                            dy30 = mao;
                            dy40 = chen;
                            dy50 = sii;
                            dy60 = wuma;
                            dy70 = wei;
                            dy80 = shen;
                            dy90 = you;
                            dy100 = xuu;
                            dy110 = hai;
                            dy120 = zii;

                        }
                        if (ydz == chou)
                        {
                            dy10 = yin;
                            dy20 = mao;
                            dy30 = chen;
                            dy40 = sii;
                            dy50 = wuma;
                            dy60 = wei;
                            dy70 = shen;
                            dy80 = you;
                            dy90 = xuu;
                            dy100 = hai;
                            dy110 = zii;
                            dy120 = chou;

                        }

                    }
                    if (ntg == jia || ntg == wuu || ntg == ren || ntg == bing || ntg == geng)
                    {
                        if (ytg == jia)
                        {
                            dyss10 = gui;
                            dyss20 = ren;
                            dyss30 = xin;
                            dyss40 = geng;
                            dyss50 = jii;
                            dyss60 = wuu;
                            dyss70 = ding;
                            dyss80 = bing;
                            dyss90 = yii;
                            dyss100 = jia;
                            dyss110 = gui;
                            dyss120 = ren;
                        }
                        if (ytg == gui)
                        {
                            dyss10 = ren;
                            dyss20 = xin;
                            dyss30 = geng;
                            dyss40 = jii;
                            dyss50 = wuu;
                            dyss60 = ding;
                            dyss70 = bing;
                            dyss80 = yii;
                            dyss90 = jia;
                            dyss100 = gui;
                            dyss110 = ren;
                            dyss120 = xin;
                        }
                        if (ytg == ren)
                        {
                            dyss10 = xin;
                            dyss20 = geng;
                            dyss30 = jii;
                            dyss40 = wuu;
                            dyss50 = ding;
                            dyss60 = bing;
                            dyss70 = yii;
                            dyss80 = jia;
                            dyss90 = gui;
                            dyss100 = ren;
                            dyss110 = xin;
                            dyss120 = geng;
                        }
                        if (ytg == xin)
                        {
                            dyss10 = geng;
                            dyss20 = jii;
                            dyss30 = wuu;
                            dyss40 = ding;
                            dyss50 = bing;
                            dyss60 = yii;
                            dyss70 = jia;
                            dyss80 = gui;
                            dyss90 = ren;
                            dyss100 = xin;
                            dyss110 = geng;
                            dyss120 = jii;
                        }
                        if (ytg == geng)
                        {
                            dyss10 = jii;
                            dyss20 = wuu;
                            dyss30 = ding;
                            dyss40 = bing;
                            dyss50 = yii;
                            dyss60 = jia;
                            dyss70 = gui;
                            dyss80 = ren;
                            dyss90 = xin;
                            dyss100 = geng;
                            dyss110 = jii;
                            dyss120 = wuu;
                        }
                        if (ytg == jii)
                        {
                            dyss10 = wuu;
                            dyss20 = ding;
                            dyss30 = bing;
                            dyss40 = yii;
                            dyss50 = jia;
                            dyss60 = gui;
                            dyss70 = ren;
                            dyss80 = xin;
                            dyss90 = geng;
                            dyss100 = jii;
                            dyss110 = wuu;
                            dyss120 = ding;
                        }
                        if (ytg == wuu)
                        {
                            dyss10 = ding;
                            dyss20 = bing;
                            dyss30 = yii;
                            dyss40 = jia;
                            dyss50 = gui;
                            dyss60 = ren;
                            dyss70 = xin;
                            dyss80 = geng;
                            dyss90 = jii;
                            dyss100 = wuu;
                            dyss110 = ding;
                            dyss120 = bing;
                        }
                        if (ytg == ding)
                        {
                            dyss10 = bing;
                            dyss20 = yii;
                            dyss30 = jia;
                            dyss40 = gui;
                            dyss50 = ren;
                            dyss60 = xin;
                            dyss70 = geng;
                            dyss80 = jii;
                            dyss90 = wuu;
                            dyss100 = ding;
                            dyss110 = bing;
                            dyss120 = jii;
                        }
                        if (ytg == bing)
                        {
                            dyss10 = yii;
                            dyss20 = jia;
                            dyss30 = gui;
                            dyss40 = ren;
                            dyss50 = xin;
                            dyss60 = geng;
                            dyss70 = jii;
                            dyss80 = wuu;
                            dyss90 = ding;
                            dyss100 = bing;
                            dyss110 = jii;
                            dyss120 = wuu;
                        }
                        if (ytg == yii)
                        {
                            dyss10 = jia;
                            dyss20 = gui;
                            dyss30 = ren;
                            dyss40 = xin;
                            dyss50 = geng;
                            dyss60 = jii;
                            dyss70 = wuu;
                            dyss80 = ding;
                            dyss90 = bing;
                            dyss100 = jii;
                            dyss110 = wuu;
                            dyss120 = ding;
                        }


                        if (ydz == yin)
                        {
                            dy10 = chou;
                            dy20 = zii;
                            dy30 = hai;
                            dy40 = xuu;
                            dy50 = you;
                            dy60 = shen;
                            dy70 = wei;
                            dy80 = wuma;
                            dy90 = sii;
                            dy100 = chen;
                            dy110 = mao;
                            dy120 = yin;

                        }
                        if (ydz == mao)
                        {
                            dy10 = yin;
                            dy20 = chou;
                            dy30 = zii;
                            dy40 = hai;
                            dy50 = xuu;
                            dy60 = you;
                            dy70 = shen;
                            dy80 = wei;
                            dy90 = wuma;
                            dy100 = sii;
                            dy110 = chen;
                            dy120 = mao;

                        }
                        if (ydz == chen)
                        {
                            dy10 = mao;
                            dy20 = yin;
                            dy30 = chou;
                            dy40 = zii;
                            dy50 = hai;
                            dy60 = xuu;
                            dy70 = you;
                            dy80 = shen;
                            dy90 = wei;
                            dy100 = wuma;
                            dy110 = sii;
                            dy120 = chen;

                        }
                        if (ydz == sii)
                        {
                            dy10 = chen;
                            dy20 = mao;
                            dy30 = yin;
                            dy40 = chou;
                            dy50 = zii;
                            dy60 = hai;
                            dy70 = xuu;
                            dy80 = you;
                            dy90 = shen;
                            dy100 = wei;
                            dy110 = wuma;
                            dy120 = sii;

                        }
                        if (ydz == wuma)
                        {
                            dy10 = sii;
                            dy20 = chen;
                            dy30 = mao;
                            dy40 = yin;
                            dy50 = chou;
                            dy60 = zii;
                            dy70 = hai;
                            dy80 = xuu;
                            dy90 = you;
                            dy100 = shen;
                            dy110 = wei;
                            dy120 = wuma;

                        }
                        if (ydz == wei)
                        {
                            dy10 = wuma;
                            dy20 = sii;
                            dy30 = chen;
                            dy40 = mao;
                            dy50 = yin;
                            dy60 = chou;
                            dy70 = zii;
                            dy80 = hai;
                            dy90 = xuu;
                            dy100 = you;
                            dy110 = shen;
                            dy120 = wei;

                        }
                        if (ydz == shen)
                        {
                            dy10 = wei;
                            dy20 = wuma;
                            dy30 = sii;
                            dy40 = chen;
                            dy50 = mao;
                            dy60 = yin;
                            dy70 = chou;
                            dy80 = zii;
                            dy90 = hai;
                            dy100 = xuu;
                            dy110 = you;
                            dy120 = shen;

                        }
                        if (ydz == you)
                        {
                            dy10 = shen;
                            dy20 = wei;
                            dy30 = wuma;
                            dy40 = sii;
                            dy50 = chen;
                            dy60 = mao;
                            dy70 = yin;
                            dy80 = chou;
                            dy90 = zii;
                            dy100 = hai;
                            dy110 = xuu;
                            dy120 = you;

                        }
                        if (ydz == xuu)
                        {
                            dy10 = you;
                            dy20 = shen;
                            dy30 = wei;
                            dy40 = wuma;
                            dy50 = sii;
                            dy60 = chen;
                            dy70 = mao;
                            dy80 = yin;
                            dy90 = chou;
                            dy100 = zii;
                            dy110 = hai;
                            dy120 = xuu;

                        }
                        if (ydz == hai)
                        {
                            dy10 = xuu;
                            dy20 = you;
                            dy30 = shen;
                            dy40 = wei;
                            dy50 = wuma;
                            dy60 = sii;
                            dy70 = chen;
                            dy80 = mao;
                            dy90 = yin;
                            dy100 = chou;
                            dy110 = zii;
                            dy120 = hai;

                        }
                        if (ydz == zii)
                        {
                            dy10 = hai;
                            dy20 = xuu;
                            dy30 = you;
                            dy40 = shen;
                            dy50 = wei;
                            dy60 = wuma;
                            dy70 = sii;
                            dy80 = chen;
                            dy90 = mao;
                            dy100 = yin;
                            dy110 = chou;
                            dy120 = zii;

                        }
                        if (ydz == chou)
                        {
                            dy10 = zii;
                            dy20 = hai;
                            dy30 = xuu;
                            dy40 = you;
                            dy50 = shen;
                            dy60 = wei;
                            dy70 = wuma;
                            dy80 = sii;
                            dy90 = chen;
                            dy100 = mao;
                            dy110 = yin;
                            dy120 = chou;

                        }

                    }
                }


                if (jia == jia)
                {

                    if (rtg == bing)
                    {
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy10 == you)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy10 == you)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy10 == shen)
                        {
                            shierchengsheng1 = changsheng;
                        }
                        if (dy10 == you)
                        {
                            shierchengsheng1 = muyu;
                        }
                        if (dy10 == xuu)
                        {
                            shierchengsheng1 = guandai;
                        }
                        if (dy10 == hai)
                        {
                            shierchengsheng1 = linguan;
                        }
                        if (dy10 == zii)
                        {
                            shierchengsheng1 = diwang;
                        }
                        if (dy10 == chou)
                        {
                            shierchengsheng1 = shuai;
                        }
                        if (dy10 == yin)
                        {
                            shierchengsheng1 = bingg;
                        }
                        if (dy10 == mao)
                        {
                            shierchengsheng1 = ssii;
                        }
                        if (dy10 == chen)
                        {
                            shierchengsheng1 = mmuu;
                        }
                        if (dy10 == sii)
                        {
                            shierchengsheng1 = jue;
                        }
                        if (dy10 == wuma)
                        {
                            shierchengsheng1 = tai;
                        }
                        if (dy10 == wei)
                        {
                            shierchengsheng1 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy20 == you)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy20 == you)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy20 == shen)
                        {
                            shierchengsheng2 = changsheng;
                        }
                        if (dy20 == you)
                        {
                            shierchengsheng2 = muyu;
                        }
                        if (dy20 == xuu)
                        {
                            shierchengsheng2 = guandai;
                        }
                        if (dy20 == hai)
                        {
                            shierchengsheng2 = linguan;
                        }
                        if (dy20 == zii)
                        {
                            shierchengsheng2 = diwang;
                        }
                        if (dy20 == chou)
                        {
                            shierchengsheng2 = shuai;
                        }
                        if (dy20 == yin)
                        {
                            shierchengsheng2 = bingg;
                        }
                        if (dy20 == mao)
                        {
                            shierchengsheng2 = ssii;
                        }
                        if (dy20 == chen)
                        {
                            shierchengsheng2 = mmuu;
                        }
                        if (dy20 == sii)
                        {
                            shierchengsheng2 = jue;
                        }
                        if (dy20 == wuma)
                        {
                            shierchengsheng2 = tai;
                        }
                        if (dy20 == wei)
                        {
                            shierchengsheng2 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy30 == you)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy30 == you)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy30 == shen)
                        {
                            shierchengsheng3 = changsheng;
                        }
                        if (dy30 == you)
                        {
                            shierchengsheng3 = muyu;
                        }
                        if (dy30 == xuu)
                        {
                            shierchengsheng3 = guandai;
                        }
                        if (dy30 == hai)
                        {
                            shierchengsheng3 = linguan;
                        }
                        if (dy30 == zii)
                        {
                            shierchengsheng3 = diwang;
                        }
                        if (dy30 == chou)
                        {
                            shierchengsheng3 = shuai;
                        }
                        if (dy30 == yin)
                        {
                            shierchengsheng3 = bingg;
                        }
                        if (dy30 == mao)
                        {
                            shierchengsheng3 = ssii;
                        }
                        if (dy30 == chen)
                        {
                            shierchengsheng3 = mmuu;
                        }
                        if (dy30 == sii)
                        {
                            shierchengsheng3 = jue;
                        }
                        if (dy30 == wuma)
                        {
                            shierchengsheng3 = tai;
                        }
                        if (dy30 == wei)
                        {
                            shierchengsheng3 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy40 == you)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy40 == you)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy40 == shen)
                        {
                            shierchengsheng4 = changsheng;
                        }
                        if (dy40 == you)
                        {
                            shierchengsheng4 = muyu;
                        }
                        if (dy40 == xuu)
                        {
                            shierchengsheng4 = guandai;
                        }
                        if (dy40 == hai)
                        {
                            shierchengsheng4 = linguan;
                        }
                        if (dy40 == zii)
                        {
                            shierchengsheng4 = diwang;
                        }
                        if (dy40 == chou)
                        {
                            shierchengsheng4 = shuai;
                        }
                        if (dy40 == yin)
                        {
                            shierchengsheng4 = bingg;
                        }
                        if (dy40 == mao)
                        {
                            shierchengsheng4 = ssii;
                        }
                        if (dy40 == chen)
                        {
                            shierchengsheng4 = mmuu;
                        }
                        if (dy40 == sii)
                        {
                            shierchengsheng4 = jue;
                        }
                        if (dy40 == wuma)
                        {
                            shierchengsheng4 = tai;
                        }
                        if (dy40 == wei)
                        {
                            shierchengsheng4 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy50 == you)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy50 == you)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy50 == shen)
                        {
                            shierchengsheng5 = changsheng;
                        }
                        if (dy50 == you)
                        {
                            shierchengsheng5 = muyu;
                        }
                        if (dy50 == xuu)
                        {
                            shierchengsheng5 = guandai;
                        }
                        if (dy50 == hai)
                        {
                            shierchengsheng5 = linguan;
                        }
                        if (dy50 == zii)
                        {
                            shierchengsheng5 = diwang;
                        }
                        if (dy50 == chou)
                        {
                            shierchengsheng5 = shuai;
                        }
                        if (dy50 == yin)
                        {
                            shierchengsheng5 = bingg;
                        }
                        if (dy50 == mao)
                        {
                            shierchengsheng5 = ssii;
                        }
                        if (dy50 == chen)
                        {
                            shierchengsheng5 = mmuu;
                        }
                        if (dy50 == sii)
                        {
                            shierchengsheng5 = jue;
                        }
                        if (dy50 == wuma)
                        {
                            shierchengsheng5 = tai;
                        }
                        if (dy50 == wei)
                        {
                            shierchengsheng5 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy60 == you)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy60 == you)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy60 == shen)
                        {
                            shierchengsheng6 = changsheng;
                        }
                        if (dy60 == you)
                        {
                            shierchengsheng6 = muyu;
                        }
                        if (dy60 == xuu)
                        {
                            shierchengsheng6 = guandai;
                        }
                        if (dy60 == hai)
                        {
                            shierchengsheng6 = linguan;
                        }
                        if (dy60 == zii)
                        {
                            shierchengsheng6 = diwang;
                        }
                        if (dy60 == chou)
                        {
                            shierchengsheng6 = shuai;
                        }
                        if (dy60 == yin)
                        {
                            shierchengsheng6 = bingg;
                        }
                        if (dy60 == mao)
                        {
                            shierchengsheng6 = ssii;
                        }
                        if (dy60 == chen)
                        {
                            shierchengsheng6 = mmuu;
                        }
                        if (dy60 == sii)
                        {
                            shierchengsheng6 = jue;
                        }
                        if (dy60 == wuma)
                        {
                            shierchengsheng6 = tai;
                        }
                        if (dy60 == wei)
                        {
                            shierchengsheng6 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy70 == you)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy70 == you)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy70 == shen)
                        {
                            shierchengsheng7 = changsheng;
                        }
                        if (dy70 == you)
                        {
                            shierchengsheng7 = muyu;
                        }
                        if (dy70 == xuu)
                        {
                            shierchengsheng7 = guandai;
                        }
                        if (dy70 == hai)
                        {
                            shierchengsheng7 = linguan;
                        }
                        if (dy70 == zii)
                        {
                            shierchengsheng7 = diwang;
                        }
                        if (dy70 == chou)
                        {
                            shierchengsheng7 = shuai;
                        }
                        if (dy70 == yin)
                        {
                            shierchengsheng7 = bingg;
                        }
                        if (dy70 == mao)
                        {
                            shierchengsheng7 = ssii;
                        }
                        if (dy70 == chen)
                        {
                            shierchengsheng7 = mmuu;
                        }
                        if (dy70 == sii)
                        {
                            shierchengsheng7 = jue;
                        }
                        if (dy70 == wuma)
                        {
                            shierchengsheng7 = tai;
                        }
                        if (dy70 == wei)
                        {
                            shierchengsheng7 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy80 == you)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy80 == you)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy80 == shen)
                        {
                            shierchengsheng8 = changsheng;
                        }
                        if (dy80 == you)
                        {
                            shierchengsheng8 = muyu;
                        }
                        if (dy80 == xuu)
                        {
                            shierchengsheng8 = guandai;
                        }
                        if (dy80 == hai)
                        {
                            shierchengsheng8 = linguan;
                        }
                        if (dy80 == zii)
                        {
                            shierchengsheng8 = diwang;
                        }
                        if (dy80 == chou)
                        {
                            shierchengsheng8 = shuai;
                        }
                        if (dy80 == yin)
                        {
                            shierchengsheng8 = bingg;
                        }
                        if (dy80 == mao)
                        {
                            shierchengsheng8 = ssii;
                        }
                        if (dy80 == chen)
                        {
                            shierchengsheng8 = mmuu;
                        }
                        if (dy80 == sii)
                        {
                            shierchengsheng8 = jue;
                        }
                        if (dy80 == wuma)
                        {
                            shierchengsheng8 = tai;
                        }
                        if (dy80 == wei)
                        {
                            shierchengsheng8 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy90 == you)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy90 == you)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy90 == shen)
                        {
                            shierchengsheng9 = changsheng;
                        }
                        if (dy90 == you)
                        {
                            shierchengsheng9 = muyu;
                        }
                        if (dy90 == xuu)
                        {
                            shierchengsheng9 = guandai;
                        }
                        if (dy90 == hai)
                        {
                            shierchengsheng9 = linguan;
                        }
                        if (dy90 == zii)
                        {
                            shierchengsheng9 = diwang;
                        }
                        if (dy90 == chou)
                        {
                            shierchengsheng9 = shuai;
                        }
                        if (dy90 == yin)
                        {
                            shierchengsheng9 = bingg;
                        }
                        if (dy90 == mao)
                        {
                            shierchengsheng9 = ssii;
                        }
                        if (dy90 == chen)
                        {
                            shierchengsheng9 = mmuu;
                        }
                        if (dy90 == sii)
                        {
                            shierchengsheng9 = jue;
                        }
                        if (dy90 == wuma)
                        {
                            shierchengsheng9 = tai;
                        }
                        if (dy90 == wei)
                        {
                            shierchengsheng9 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy100 == you)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy100 == you)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy100 == shen)
                        {
                            shierchengsheng10 = changsheng;
                        }
                        if (dy100 == you)
                        {
                            shierchengsheng10 = muyu;
                        }
                        if (dy100 == xuu)
                        {
                            shierchengsheng10 = guandai;
                        }
                        if (dy100 == hai)
                        {
                            shierchengsheng10 = linguan;
                        }
                        if (dy100 == zii)
                        {
                            shierchengsheng10 = diwang;
                        }
                        if (dy100 == chou)
                        {
                            shierchengsheng10 = shuai;
                        }
                        if (dy100 == yin)
                        {
                            shierchengsheng10 = bingg;
                        }
                        if (dy100 == mao)
                        {
                            shierchengsheng10 = ssii;
                        }
                        if (dy100 == chen)
                        {
                            shierchengsheng10 = mmuu;
                        }
                        if (dy100 == sii)
                        {
                            shierchengsheng10 = jue;
                        }
                        if (dy100 == wuma)
                        {
                            shierchengsheng10 = tai;
                        }
                        if (dy100 == wei)
                        {
                            shierchengsheng10 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy110 == you)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy110 == you)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy110 == shen)
                        {
                            shierchengsheng11 = changsheng;
                        }
                        if (dy110 == you)
                        {
                            shierchengsheng11 = muyu;
                        }
                        if (dy110 == xuu)
                        {
                            shierchengsheng11 = guandai;
                        }
                        if (dy110 == hai)
                        {
                            shierchengsheng11 = linguan;
                        }
                        if (dy110 == zii)
                        {
                            shierchengsheng11 = diwang;
                        }
                        if (dy110 == chou)
                        {
                            shierchengsheng11 = shuai;
                        }
                        if (dy110 == yin)
                        {
                            shierchengsheng11 = bingg;
                        }
                        if (dy110 == mao)
                        {
                            shierchengsheng11 = ssii;
                        }
                        if (dy110 == chen)
                        {
                            shierchengsheng11 = mmuu;
                        }
                        if (dy110 == sii)
                        {
                            shierchengsheng11 = jue;
                        }
                        if (dy110 == wuma)
                        {
                            shierchengsheng11 = tai;
                        }
                        if (dy110 == wei)
                        {
                            shierchengsheng11 = yang;
                        }

                    }
                    if (rtg == bing)
                    {
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == wuu)
                    {
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == ding)
                    {
                        if (dy120 == you)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == jii)
                    {
                        if (dy120 == you)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == yii)
                    {
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == xin)
                    {
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == gui)
                    {
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == jia)
                    {
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == geng)
                    {
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                    if (rtg == ren)
                    {
                        if (dy120 == shen)
                        {
                            shierchengsheng12 = changsheng;
                        }
                        if (dy120 == you)
                        {
                            shierchengsheng12 = muyu;
                        }
                        if (dy120 == xuu)
                        {
                            shierchengsheng12 = guandai;
                        }
                        if (dy120 == hai)
                        {
                            shierchengsheng12 = linguan;
                        }
                        if (dy120 == zii)
                        {
                            shierchengsheng12 = diwang;
                        }
                        if (dy120 == chou)
                        {
                            shierchengsheng12 = shuai;
                        }
                        if (dy120 == yin)
                        {
                            shierchengsheng12 = bingg;
                        }
                        if (dy120 == mao)
                        {
                            shierchengsheng12 = ssii;
                        }
                        if (dy120 == chen)
                        {
                            shierchengsheng12 = mmuu;
                        }
                        if (dy120 == sii)
                        {
                            shierchengsheng12 = jue;
                        }
                        if (dy120 == wuma)
                        {
                            shierchengsheng12 = tai;
                        }
                        if (dy120 == wei)
                        {
                            shierchengsheng12 = yang;
                        }

                    }
                }
                if (dayunyin == 1)
                {

                    groupBoxyin.Text += " " + shierchengsheng1 + " ";

                    groupBoxmao.Text += " " + shierchengsheng2 + " ";

                    groupBoxchen.Text += " " + shierchengsheng3 + " ";

                    groupBoxsi.Text += " " + shierchengsheng4 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng5 + " ";

                    groupBoxwei.Text += " " + shierchengsheng6 + " ";

                    groupBoxshen.Text += " " + shierchengsheng7 + " ";

                    groupBoxyou.Text += " " + shierchengsheng8 + " ";

                    groupBoxxu.Text += " " + shierchengsheng9 + " ";

                    groupBoxhai.Text += " " + shierchengsheng10 + " ";

                    groupBoxzi.Text += " " + shierchengsheng11 + " ";

                    groupBoxchou.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunmao == 1)
                {

                    groupBoxmao.Text += " " + shierchengsheng1 + " ";

                    groupBoxchen.Text += " " + shierchengsheng2 + " ";

                    groupBoxsi.Text += " " + shierchengsheng3 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng4 + " ";

                    groupBoxwei.Text += " " + shierchengsheng5 + " ";

                    groupBoxshen.Text += " " + shierchengsheng6 + " ";

                    groupBoxyou.Text += " " + shierchengsheng7 + " ";

                    groupBoxxu.Text += " " + shierchengsheng8 + " ";

                    groupBoxhai.Text += " " + shierchengsheng9 + " ";

                    groupBoxzi.Text += " " + shierchengsheng10 + " ";

                    groupBoxchou.Text += " " + shierchengsheng11 + " ";

                    groupBoxyin.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunchen == 1)
                {

                    groupBoxchen.Text += " " + shierchengsheng1 + " ";

                    groupBoxsi.Text += " " + shierchengsheng2 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng3 + " ";

                    groupBoxwei.Text += " " + shierchengsheng4 + " ";

                    groupBoxshen.Text += " " + shierchengsheng5 + " ";

                    groupBoxyou.Text += " " + shierchengsheng6 + " ";

                    groupBoxxu.Text += " " + shierchengsheng7 + " ";

                    groupBoxhai.Text += " " + shierchengsheng8 + " ";

                    groupBoxzi.Text += " " + shierchengsheng9 + " ";

                    groupBoxchou.Text += " " + shierchengsheng10 + " ";

                    groupBoxyin.Text += " " + shierchengsheng11 + " ";

                    groupBoxmao.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunsi == 1)
                {

                    groupBoxsi.Text += " " + shierchengsheng1 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng2 + " ";

                    groupBoxwei.Text += " " + shierchengsheng3 + " ";

                    groupBoxshen.Text += " " + shierchengsheng4 + " ";

                    groupBoxyou.Text += " " + shierchengsheng5 + " ";

                    groupBoxxu.Text += " " + shierchengsheng6 + " ";

                    groupBoxhai.Text += " " + shierchengsheng7 + " ";

                    groupBoxzi.Text += " " + shierchengsheng8 + " ";

                    groupBoxchou.Text += " " + shierchengsheng9 + " ";

                    groupBoxyin.Text += " " + shierchengsheng10 + " ";

                    groupBoxmao.Text += " " + shierchengsheng11 + " ";

                    groupBoxchen.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunwu == 1)
                {

                    groupBoxwuma.Text += " " + shierchengsheng1 + " ";

                    groupBoxwei.Text += " " + shierchengsheng2 + " ";

                    groupBoxshen.Text += " " + shierchengsheng3 + " ";

                    groupBoxyou.Text += " " + shierchengsheng4 + " ";

                    groupBoxxu.Text += " " + shierchengsheng5 + " ";

                    groupBoxhai.Text += " " + shierchengsheng6 + " ";

                    groupBoxzi.Text += " " + shierchengsheng7 + " ";

                    groupBoxchou.Text += " " + shierchengsheng8 + " ";

                    groupBoxyin.Text += " " + shierchengsheng9 + " ";

                    groupBoxmao.Text += " " + shierchengsheng10 + " ";

                    groupBoxchen.Text += " " + shierchengsheng11 + " ";

                    groupBoxsi.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunwei == 1)
                {

                    groupBoxwei.Text += " " + shierchengsheng1 + " ";

                    groupBoxshen.Text += " " + shierchengsheng2 + " ";

                    groupBoxyou.Text += " " + shierchengsheng3 + " ";

                    groupBoxxu.Text += " " + shierchengsheng4 + " ";

                    groupBoxhai.Text += " " + shierchengsheng5 + " ";

                    groupBoxzi.Text += " " + shierchengsheng6 + " ";

                    groupBoxchou.Text += " " + shierchengsheng7 + " ";

                    groupBoxyin.Text += " " + shierchengsheng8 + " ";

                    groupBoxmao.Text += " " + shierchengsheng9 + " ";

                    groupBoxchen.Text += " " + shierchengsheng10 + " ";

                    groupBoxsi.Text += " " + shierchengsheng11 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunshen == 1)
                {

                    groupBoxshen.Text += " " + shierchengsheng1 + " ";

                    groupBoxyou.Text += " " + shierchengsheng2 + " ";

                    groupBoxxu.Text += " " + shierchengsheng3 + " ";

                    groupBoxhai.Text += " " + shierchengsheng4 + " ";

                    groupBoxzi.Text += " " + shierchengsheng5 + " ";

                    groupBoxchou.Text += " " + shierchengsheng6 + " ";

                    groupBoxyin.Text += " " + shierchengsheng7 + " ";

                    groupBoxmao.Text += " " + shierchengsheng8 + " ";

                    groupBoxchen.Text += " " + shierchengsheng9 + " ";

                    groupBoxsi.Text += " " + shierchengsheng10 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng11 + " ";

                    groupBoxwei.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunyou == 1)
                {

                    groupBoxyou.Text += " " + shierchengsheng1 + " ";

                    groupBoxxu.Text += " " + shierchengsheng2 + " ";

                    groupBoxhai.Text += " " + shierchengsheng3 + " ";

                    groupBoxzi.Text += " " + shierchengsheng4 + " ";

                    groupBoxchou.Text += " " + shierchengsheng5 + " ";

                    groupBoxyin.Text += " " + shierchengsheng6 + " ";

                    groupBoxmao.Text += " " + shierchengsheng7 + " ";

                    groupBoxchen.Text += " " + shierchengsheng8 + " ";

                    groupBoxsi.Text += " " + shierchengsheng9 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng10 + " ";

                    groupBoxwei.Text += " " + shierchengsheng11 + " ";

                    groupBoxshen.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunxu == 1)
                {

                    groupBoxxu.Text += " " + shierchengsheng1 + " ";

                    groupBoxhai.Text += " " + shierchengsheng2 + " ";

                    groupBoxzi.Text += " " + shierchengsheng3 + " ";

                    groupBoxchou.Text += " " + shierchengsheng4 + " ";

                    groupBoxyin.Text += " " + shierchengsheng5 + " ";

                    groupBoxmao.Text += " " + shierchengsheng6 + " ";

                    groupBoxchen.Text += " " + shierchengsheng7 + " ";

                    groupBoxsi.Text += " " + shierchengsheng8 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng9 + " ";

                    groupBoxwei.Text += " " + shierchengsheng10 + " ";

                    groupBoxshen.Text += " " + shierchengsheng11 + " ";

                    groupBoxyou.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunhai == 1)
                {

                    groupBoxhai.Text += " " + shierchengsheng1 + " ";

                    groupBoxzi.Text += " " + shierchengsheng2 + " ";

                    groupBoxchou.Text += " " + shierchengsheng3 + " ";

                    groupBoxyin.Text += " " + shierchengsheng4 + " ";

                    groupBoxmao.Text += " " + shierchengsheng5 + " ";

                    groupBoxchen.Text += " " + shierchengsheng6 + " ";

                    groupBoxsi.Text += " " + shierchengsheng7 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng8 + " ";

                    groupBoxwei.Text += " " + shierchengsheng9 + " ";

                    groupBoxshen.Text += " " + shierchengsheng10 + " ";

                    groupBoxyou.Text += " " + shierchengsheng11 + " ";

                    groupBoxxu.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunzi == 1)
                {

                    groupBoxzi.Text += " " + shierchengsheng1 + " ";

                    groupBoxchou.Text += " " + shierchengsheng2 + " ";

                    groupBoxyin.Text += " " + shierchengsheng3 + " ";

                    groupBoxmao.Text += " " + shierchengsheng4 + " ";

                    groupBoxchen.Text += " " + shierchengsheng5 + " ";

                    groupBoxsi.Text += " " + shierchengsheng6 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng7 + " ";

                    groupBoxwei.Text += " " + shierchengsheng8 + " ";

                    groupBoxshen.Text += " " + shierchengsheng9 + " ";

                    groupBoxyou.Text += " " + shierchengsheng10 + " ";

                    groupBoxxu.Text += " " + shierchengsheng11 + " ";

                    groupBoxhai.Text += " " + shierchengsheng12 + " ";
                }
                if (dayunchou == 1)
                {

                    groupBoxchou.Text += " " + shierchengsheng1 + " ";

                    groupBoxyin.Text += " " + shierchengsheng2 + " ";

                    groupBoxmao.Text += " " + shierchengsheng3 + " ";

                    groupBoxchen.Text += " " + shierchengsheng4 + " ";

                    groupBoxsi.Text += " " + shierchengsheng5 + " ";

                    groupBoxwuma.Text += " " + shierchengsheng6 + " ";

                    groupBoxwei.Text += " " + shierchengsheng7 + " ";

                    groupBoxshen.Text += " " + shierchengsheng8 + " ";

                    groupBoxyou.Text += " " + shierchengsheng9 + " ";

                    groupBoxxu.Text += " " + shierchengsheng10 + " ";

                    groupBoxhai.Text += " " + shierchengsheng11 + " ";

                    groupBoxzi.Text += " " + shierchengsheng12 + " ";
                }

            }
            //宫位内脏
            if (jia == jia)
            {
                groupBoxyin.Text += " 肺 ";
                groupBoxmao.Text += " 大肠 ";
                groupBoxchen.Text += " 胃 ";
                groupBoxsi.Text += " 脾 ";
                groupBoxwuma.Text += " 心 ";
                groupBoxwei.Text += " 小肠 ";
                groupBoxshen.Text += " 膀胱 ";
                groupBoxyou.Text += " 肾 ";
                groupBoxxu.Text += " 心包 ";
                groupBoxhai.Text += " 三焦 ";
                groupBoxzi.Text += " 胆 ";
                groupBoxchou.Text += " 肝 ";
            }


        }//排盘核心功能
        private void ShiJianPaipan_Click(object sender, EventArgs e)
        {
            //获取时间
            int yeartimeint = (int)numericUpDownyear.Value;
            int mothtimeint = (int)numericUpDownmonth.Value;
            int daytimeint = (int)numericUpDownday.Value;
            int hourtimeint = (int)numericUpDownhour.Value;

            //农历
            if (checkBox1.Checked == true)
            {
                //创建农历实例
                var lunarDay = LunarDay.FromYmd(yeartimeint, mothtimeint, daytimeint);
                //农历查公历
                var solarDay = lunarDay.GetSolarDay();
                //从农历查公历年月日
                int year = solarDay.Year;
                int month = solarDay.Month;
                int day = solarDay.Day;

                monthNL = mothtimeint;
                dayNL = daytimeint;
                hourNL = hourtimeint;
                //查农历月天数
                var MonthTianShu = LunarMonth.FromYm(yeartimeint, mothtimeint);
                int dayCount = MonthTianShu.DayCount;
                //设置控件天数
                numericUpDownday.Maximum = dayCount;
                //查天干地支
                var tiangandizhi = lunarDay.GetSixtyCycleDay();
                var vartiangann = tiangandizhi.Year.HeavenStem;
                var vardizhin = tiangandizhi.Year.EarthBranch;
                var vartiangany = tiangandizhi.Month.HeavenStem;
                var vardizhiy = tiangandizhi.Month.EarthBranch;
                var vartianganr = tiangandizhi.Day.HeavenStem;
                var vardizhir = tiangandizhi.Day.EarthBranch;

                string strtiangann = vartiangann.ToString();
                string strdizhin = vardizhin.ToString();
                string strtiangany = vartiangany.ToString();
                string strdizhiy = vardizhiy.ToString();
                string strtianganr = vartianganr.ToString();
                string strdizhir = vardizhir.ToString();

                ntg = strtiangann;
                ndz = strdizhin;
                ytg = strtiangany;
                ydz = strdizhiy;
                rtg = strtianganr;
                rdz = strdizhir;

                LabelDayTime.Text = "公历：" + year + "年" + month + "月" + day + "日 ";
                //节气
                var term = solarDay.Term;
                string termstr = term.ToString();//输出
                // 节气的公历日
                var termSolarDay = term.GetSolarDay();
                string termSolarDaystr = termSolarDay.ToString();//输出
                // 下一个节气
                var nextTerm = term.Next(1);
                string nextTermstr = nextTerm.ToString();//输出
                // 下一个节气的公历日
                var nextTermSolarDay = nextTerm.GetSolarDay();
                string nextTermSolarDaystr = nextTermSolarDay.ToString();//输出
                //输出行大运
                labeljieqi.Text = termstr + " " + termSolarDaystr + "   " + nextTermstr + " " + nextTermSolarDaystr;

            }
            //公历
            if (checkBox1.Checked == false)
            {
                //公历转农历
                var solarDay = SolarDay.FromYmd(yeartimeint, mothtimeint, daytimeint);
                //公历查农历日期
                var lunarDay = solarDay.GetLunarDay();
                //查农历年月日
                int year = lunarDay.Year;
                int month = lunarDay.Month;
                int day = lunarDay.Day;

                monthNL = lunarDay.Month;
                dayNL = lunarDay.Day;
                hourNL = hourtimeint;
                //查公历月最大天数
                var MonthTianShu = SolarMonth.FromYm(yeartimeint, mothtimeint);
                int dayCount = MonthTianShu.DayCount;
                //设置控件天数
                numericUpDownday.Maximum = dayCount;
                //查天干地支
                var tiangandizhi = solarDay.GetSixtyCycleDay();
                //时干支
                var vartiangann = tiangandizhi.Year.HeavenStem;
                var vardizhin = tiangandizhi.Year.EarthBranch;
                var vartiangany = tiangandizhi.Month.HeavenStem;
                var vardizhiy = tiangandizhi.Month.EarthBranch;
                var vartianganr = tiangandizhi.Day.HeavenStem;
                var vardizhir = tiangandizhi.Day.EarthBranch;

                string strtiangann = vartiangann.ToString();
                string strdizhin = vardizhin.ToString();
                string strtiangany = vartiangany.ToString();
                string strdizhiy = vardizhiy.ToString();
                string strtianganr = vartianganr.ToString();
                string strdizhir = vardizhir.ToString();

                ntg = strtiangann;
                ndz = strdizhin;
                ytg = strtiangany;
                ydz = strdizhiy;
                rtg = strtianganr;
                rdz = strdizhir;

                LabelDayTime.Text = "农历：" + year + "年" + month + "月" + day + "日 ";
                //节气
                var term = solarDay.Term;
                string termstr = term.ToString();//输出
                // 节气的公历日
                var termSolarDay = term.GetSolarDay();
                string termSolarDaystr = termSolarDay.ToString();//输出
                // 下一个节气
                var nextTerm = term.Next(1);
                string nextTermstr = nextTerm.ToString();//输出
                // 下一个节气的公历日
                var nextTermSolarDay = nextTerm.GetSolarDay();
                string nextTermSolarDaystr = nextTermSolarDay.ToString();//输出
                //输出行大运
                labeljieqi.Text = termstr + " " + termSolarDaystr + "   " + nextTermstr + " " + nextTermSolarDaystr;

            }
            //五鼠遁查时干支
            if (jia == jia)
            {
                if (hourtimeint == 0 || hourtimeint == 23)
                {
                    sdz = zii;
                }
                if (hourtimeint == 1 || hourtimeint == 2)
                {
                    sdz = chou;
                }
                if (hourtimeint == 3 || hourtimeint == 4)
                {
                    sdz = yin;
                }
                if (hourtimeint == 5 || hourtimeint == 6)
                {
                    sdz = mao;
                }
                if (hourtimeint == 7 || hourtimeint == 8)
                {
                    sdz = chen;
                }
                if (hourtimeint == 9 || hourtimeint == 10)
                {
                    sdz = sii;
                }
                if (hourtimeint == 11 || hourtimeint == 12)
                {
                    sdz = wuma;
                }
                if (hourtimeint == 13 || hourtimeint == 14)
                {
                    sdz = wei;
                }
                if (hourtimeint == 15 || hourtimeint == 16)
                {
                    sdz = shen;
                }
                if (hourtimeint == 17 || hourtimeint == 18)
                {
                    sdz = you;
                }
                if (hourtimeint == 19 || hourtimeint == 20)
                {
                    sdz = xuu;
                }
                if (hourtimeint == 21 || hourtimeint == 22)
                {
                    sdz = hai;
                }

                if (rtg == jia || rtg == jii)
                {
                    if (sdz == zii)
                    {
                        stg = jia;
                    }
                    if (sdz == chou)
                    {
                        stg = yii;
                    }
                    if (sdz == yin)
                    {
                        stg = bing;
                    }
                    if (sdz == mao)
                    {
                        stg = ding;
                    }
                    if (sdz == chen)
                    {
                        stg = wuu;
                    }
                    if (sdz == sii)
                    {
                        stg = jii;
                    }
                    if (sdz == wuma)
                    {
                        stg = geng;
                    }
                    if (sdz == wei)
                    {
                        stg = xin;
                    }
                    if (sdz == shen)
                    {
                        stg = ren;
                    }
                    if (sdz == you)
                    {
                        stg = gui;
                    }
                    if (sdz == xuu)
                    {
                        stg = jia;
                    }
                    if (sdz == hai)
                    {
                        stg = yii;
                    }
                }
                if (rtg == yii || rtg == geng)
                {
                    if (sdz == zii)
                    {
                        stg = bing;
                    }
                    if (sdz == chou)
                    {
                        stg = ding;
                    }
                    if (sdz == yin)
                    {
                        stg = wuu;
                    }
                    if (sdz == mao)
                    {
                        stg = jii;
                    }
                    if (sdz == chen)
                    {
                        stg = geng;
                    }
                    if (sdz == sii)
                    {
                        stg = xin;
                    }
                    if (sdz == wuma)
                    {
                        stg = ren;
                    }
                    if (sdz == wei)
                    {
                        stg = gui;
                    }
                    if (sdz == shen)
                    {
                        stg = jia;
                    }
                    if (sdz == you)
                    {
                        stg = yii;
                    }
                    if (sdz == xuu)
                    {
                        stg = bing;
                    }
                    if (sdz == hai)
                    {
                        stg = ding;
                    }
                }
                if (rtg == bing || rtg == xin)
                {
                    if (sdz == zii)
                    {
                        stg = wuu;
                    }
                    if (sdz == chou)
                    {
                        stg = jii;
                    }
                    if (sdz == yin)
                    {
                        stg = geng;
                    }
                    if (sdz == mao)
                    {
                        stg = xin;
                    }
                    if (sdz == chen)
                    {
                        stg = ren;
                    }
                    if (sdz == sii)
                    {
                        stg = gui;
                    }
                    if (sdz == wuma)
                    {
                        stg = jia;
                    }
                    if (sdz == wei)
                    {
                        stg = yii;
                    }
                    if (sdz == shen)
                    {
                        stg = bing;
                    }
                    if (sdz == you)
                    {
                        stg = ding;
                    }
                    if (sdz == xuu)
                    {
                        stg = wuu;
                    }
                    if (sdz == hai)
                    {
                        stg = jii;
                    }
                }
                if (rtg == ding || rtg == ren)
                {
                    if (sdz == zii)
                    {
                        stg = geng;
                    }
                    if (sdz == chou)
                    {
                        stg = xin;
                    }
                    if (sdz == yin)
                    {
                        stg = ren;
                    }
                    if (sdz == mao)
                    {
                        stg = gui;
                    }
                    if (sdz == chen)
                    {
                        stg = jia;
                    }
                    if (sdz == sii)
                    {
                        stg = yii;
                    }
                    if (sdz == wuma)
                    {
                        stg = bing;
                    }
                    if (sdz == wei)
                    {
                        stg = ding;
                    }
                    if (sdz == shen)
                    {
                        stg = wuu;
                    }
                    if (sdz == you)
                    {
                        stg = jii;
                    }
                    if (sdz == xuu)
                    {
                        stg = geng;
                    }
                    if (sdz == hai)
                    {
                        stg = xin;
                    }
                }
                if (rtg == wuu || rtg == gui)
                {
                    if (sdz == zii)
                    {
                        stg = ren;
                    }
                    if (sdz == chou)
                    {
                        stg = gui;
                    }
                    if (sdz == yin)
                    {
                        stg = jia;
                    }
                    if (sdz == mao)
                    {
                        stg = yii;
                    }
                    if (sdz == chen)
                    {
                        stg = bing;
                    }
                    if (sdz == sii)
                    {
                        stg = ding;
                    }
                    if (sdz == wuma)
                    {
                        stg = wuu;
                    }
                    if (sdz == wei)
                    {
                        stg = jii;
                    }
                    if (sdz == shen)
                    {
                        stg = geng;
                    }
                    if (sdz == you)
                    {
                        stg = xin;
                    }
                    if (sdz == xuu)
                    {
                        stg = ren;
                    }
                    if (sdz == hai)
                    {
                        stg = gui;
                    }
                }

            }

            //排盘
            ZiWeiPaiPan_Click(this, new EventArgs());

        }//从时间获取天干地支节气
        private void wuhudun_Click(object sender, EventArgs e)
        {
            tiangan = "";
            if (ntg == jia || ntg == jii)
            {
                if (dizhi == zii)
                {
                    tiangan = bing;
                }
                if (dizhi == chou)
                {
                    tiangan = ding;
                }
                if (dizhi == yin)
                {
                    tiangan = bing;
                }
                if (dizhi == mao)
                {
                    tiangan = ding;
                }
                if (dizhi == chen)
                {
                    tiangan = wuu;
                }
                if (dizhi == sii)
                {
                    tiangan = jii;
                }
                if (dizhi == wuma)
                {
                    tiangan = geng;
                }
                if (dizhi == wei)
                {
                    tiangan = xin;
                }
                if (dizhi == shen)
                {
                    tiangan = ren;
                }
                if (dizhi == you)
                {
                    tiangan = gui;
                }
                if (dizhi == xuu)
                {
                    tiangan = jia;
                }
                if (dizhi == hai)
                {
                    tiangan = yii;
                }
            }
            if (ntg == yii || ntg == geng)
            {
                if (dizhi == zii)
                {
                    tiangan = wuu;
                }
                if (dizhi == chou)
                {
                    tiangan = jii;
                }
                if (dizhi == yin)
                {
                    tiangan = wuu;
                }
                if (dizhi == mao)
                {
                    tiangan = jii;
                }
                if (dizhi == chen)
                {
                    tiangan = geng;
                }
                if (dizhi == sii)
                {
                    tiangan = xin;
                }
                if (dizhi == wuma)
                {
                    tiangan = ren;
                }
                if (dizhi == wei)
                {
                    tiangan = gui;
                }
                if (dizhi == shen)
                {
                    tiangan = jia;
                }
                if (dizhi == you)
                {
                    tiangan = yii;
                }
                if (dizhi == xuu)
                {
                    tiangan = bing;
                }
                if (dizhi == hai)
                {
                    tiangan = ding;
                }
            }
            if (ntg == bing || ntg == xin)
            {
                if (dizhi == zii)
                {
                    tiangan = geng;
                }
                if (dizhi == chou)
                {
                    tiangan = xin;
                }
                if (dizhi == yin)
                {
                    tiangan = geng;
                }
                if (dizhi == mao)
                {
                    tiangan = xin;
                }
                if (dizhi == chen)
                {
                    tiangan = ren;
                }
                if (dizhi == sii)
                {
                    tiangan = gui;
                }
                if (dizhi == wuma)
                {
                    tiangan = jia;
                }
                if (dizhi == wei)
                {
                    tiangan = yii;
                }
                if (dizhi == shen)
                {
                    tiangan = bing;
                }
                if (dizhi == you)
                {
                    tiangan = ding;
                }
                if (dizhi == xuu)
                {
                    tiangan = wuu;
                }
                if (dizhi == hai)
                {
                    tiangan = jii;
                }
            }
            if (ntg == ding || ntg == ren)
            {
                if (dizhi == zii)
                {
                    tiangan = ren;
                }
                if (dizhi == chou)
                {
                    tiangan = gui;
                }
                if (dizhi == yin)
                {
                    tiangan = ren;
                }
                if (dizhi == mao)
                {
                    tiangan = gui;
                }
                if (dizhi == chen)
                {
                    tiangan = jia;
                }
                if (dizhi == sii)
                {
                    tiangan = yii;
                }
                if (dizhi == wuma)
                {
                    tiangan = bing;
                }
                if (dizhi == wei)
                {
                    tiangan = ding;
                }
                if (dizhi == shen)
                {
                    tiangan = wuu;
                }
                if (dizhi == you)
                {
                    tiangan = jii;
                }
                if (dizhi == xuu)
                {
                    tiangan = geng;
                }
                if (dizhi == hai)
                {
                    tiangan = xin;
                }
            }
            if (ntg == wuu || ntg == gui)
            {
                if (dizhi == zii)
                {
                    tiangan = jia;
                }
                if (dizhi == chou)
                {
                    tiangan = yii;
                }
                if (dizhi == yin)
                {
                    tiangan = jia;
                }
                if (dizhi == mao)
                {
                    tiangan = yii;
                }
                if (dizhi == chen)
                {
                    tiangan = bing;
                }
                if (dizhi == sii)
                {
                    tiangan = ding;
                }
                if (dizhi == wuma)
                {
                    tiangan = wuu;
                }
                if (dizhi == wei)
                {
                    tiangan = jii;
                }
                if (dizhi == shen)
                {
                    tiangan = geng;
                }
                if (dizhi == you)
                {
                    tiangan = xin;
                }
                if (dizhi == xuu)
                {
                    tiangan = ren;
                }
                if (dizhi == hai)
                {
                    tiangan = gui;
                }
            }

        }//五虎遁查干
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void YueTianShu_Click(object sender, EventArgs e)
        {
            //获取时间
            int yeartimeint = (int)numericUpDownyear.Value;
            int mothtimeint = (int)numericUpDownmonth.Value;
            if (checkBox1.Checked == true)//农历月
            {
                //查农历月天数
                var MonthTianShu = LunarMonth.FromYm(yeartimeint, mothtimeint);
                int dayCount = MonthTianShu.DayCount;
                //设置控件天数
                numericUpDownday.Maximum = dayCount;
            }
            if (checkBox1.Checked == false)//公历月
            {
                //查公历月最大天数
                var MonthTianShu = SolarMonth.FromYm(yeartimeint, mothtimeint);
                int dayCount = MonthTianShu.DayCount;
                //设置控件天数
                numericUpDownday.Maximum = dayCount;
            }
            // 在这里处理数值变化后点击时间排盘
            ShiJianPaipan_Click(this, new EventArgs());
        }//获取月天数
        private void numericUpDownmonth_ValueChanged(object sender, EventArgs e)
        {
            YueTianShu_Click(this, new EventArgs());
            ShiJianPaipan_Click(this, new EventArgs());
        }
        private void numericUpDownday_ValueChanged(object sender, EventArgs e)
        {
            YueTianShu_Click(this, new EventArgs());
            ShiJianPaipan_Click(this, new EventArgs());
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            YueTianShu_Click(this, new EventArgs());
        }
        private void numericUpDownyear_ValueChanged(object sender, EventArgs e)
        {
            YueTianShu_Click(this, new EventArgs());
            ShiJianPaipan_Click(this, new EventArgs());
        }
        private void numericUpDownhour_ValueChanged(object sender, EventArgs e)
        {
            YueTianShu_Click(this, new EventArgs());
            ShiJianPaipan_Click(this, new EventArgs());
        }

    }
}
