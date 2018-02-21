using System;
using System.Windows.Forms;
using Fiddler;
using System.Web;
using Newtonsoft.Json;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Diagnostics;

namespace MatematikFessor
{
    public partial class MatFessorForm : Form
    {
        public MatFessorForm()
        {
            InitializeComponent();
        }

        static int QuestionOverrides = 0;
        static int AnswerOverrides = 0;
        static int AnswersSent = 0;

        static string cookies = null;

        void OverwritenQuestion()
        {
            txtQuestionOverwrites.BeginInvoke((MethodInvoker)delegate () { txtQuestionOverwrites.Text = $"Overwrites: {++QuestionOverrides}"; });
        }
        void OverwritenAnswer()
        {
            txtAnswerOverwrites.BeginInvoke((MethodInvoker)delegate () { txtAnswerOverwrites.Text = $"Overwrites: {++AnswerOverrides}"; });
        }
        void SentAnswer()
        {
            txtAdaptiveTrainingAnswers.BeginInvoke((MethodInvoker)delegate () { txtAdaptiveTrainingAnswers.Text = $"Answers: {++AnswersSent}"; });
        }

        private void FiddlerApplication_BeforeResponse(Session sess)
        {
            if (sess.RequestMethod == "CONNECT")
                return;

            if (sess.url.Contains("matematikfessor") && cookies == null)
            {
                cookies = sess.RequestHeaders.AllValues("Cookie");
                Debug.WriteLine($"Recieved cookies ({cookies})");
            }

            if (sess.url.Contains("save_answer") && chkOverwriteAnswers.Checked)
            {
                sess.utilSetResponseBody("{\"saved\":true,\"correct\":true}");
                Debug.WriteLine($"Overwrote Save");
                OverwritenAnswer();
            }

            if (sess.url.Contains("get_question") && chkOverwriteQuestions.Checked)
            {
                sess.utilSetResponseBody(Encoding.Default.GetString(
                    Convert.FromBase64String(
                       "eyAgDQogICAiUXVlc3Rpb24iOnsgIA0KICAgICAgImlkIjoyMTAzNjAsDQogICAgICAidHlwZSI6MSwNCiAgICAgICJxdWVzdGlvbiI6IjxwPlN2YXJldCBlciA3PFwvcD4iLA0KICAgICAgImV4cGxhbmF0aW9uIjoiPHA+U3ZhcmV0IGVyIDc8XC9wPiIsDQogICAgICAibGVzc29uX2lkIjo4MjcsDQogICAgICAibWVkaWFfaWQiOm51bGwsDQogICAgICAiYWN0aXZlIjp0cnVlLA0KICAgICAgInBvaW50Ijo0LA0KICAgICAgInB1YmxpYyI6dHJ1ZSwNCiAgICAgICJpbmRlcGVuZGVudCI6IjEiDQogICB9LA0KICAgIkxlc3NvbiI6eyAgDQogICAgICAiaWQiOiI4MjciLA0KICAgICAgInRpdGxlIjoiU3ZhcmV0IGVyIDciDQogICB9LA0KICAgIlRvcGljIjp7ICANCiAgICAgICJpZCI6IjY4IiwNCiAgICAgICJuYW1lIjoiRnVua3Rpb25lciINCiAgIH0sDQogICAiTWVkaWEiOnsgIA0KICAgICAgInR5cGUiOm51bGwsDQogICAgICAidHlwZV9pZCI6bnVsbA0KICAgfSwNCiAgICJVc2VyTWVkaWEiOnsgIA0KICAgICAgInR5cGUiOm51bGwsDQogICAgICAiaWRlbnRpZmllciI6bnVsbA0KICAgfSwNCiAgICJBbnN3ZXIiOnsgIA0KICAgICAgInVuaXQiOm51bGwNCiAgIH0NCn0=")));
                Debug.WriteLine($"Overwrote Question");
                OverwritenQuestion();
            }
        }

        private void btnStopInterception_Click(object sender, EventArgs e)
        {
            FiddlerApplication.Shutdown();
        }
        private void MatFessorForm_Load(object sender, EventArgs e)
        {
            CertMaker.createRootCert();
            CertMaker.trustRootCert();

            FiddlerApplication.BeforeRequest += delegate (Fiddler.Session oSession)
            {
                oSession.bBufferResponse = true;
            };

            FiddlerApplication.BeforeResponse += FiddlerApplication_BeforeResponse;
            
            FiddlerApplication.Startup(8888, true, true, true);

            new Thread(async () =>
            {
                while (true)
                {
                    Thread.Sleep(50);

                    if (cookies != null)
                    {
                        if (!chkSpamAdaptiveTrainingAnswers.Checked)
                            continue;

                        // Spam Thread
                        //new Thread(async () =>
                        //{
                        var baseAddress = new Uri("https://www.matematikfessor.dk");
                        var cookieContainer = new CookieContainer();
                        using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })

                        using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
                        {
                            var values = new Dictionary<string, string>
                            {
                                { "data[Test][question_id]", "747884" },
                                { "data[Test][result_iae_data]", "{\"chosen_answers\":[{\"value\":57}]}" }
                            };

                            var content = new FormUrlEncodedContent(values);

                            string[] szSplitCookies = cookies.Split(';');

                            cookieContainer.Add(baseAddress, new Cookie("__cfduid", szSplitCookies[0].Split('=')[1]));
                            cookieContainer.Add(baseAddress, new Cookie("CAKEPHP", szSplitCookies[1].Split('=')[1]));


                            var postResult = await client.PostAsync("/adaptive_test/save_answer", content);

                            string htmlResult = await postResult.Content.ReadAsStringAsync();
                            Debug.WriteLine(htmlResult);

                            SentAnswer();
                        }
                        //}).Start();
                    }
                }
            }).Start();
        }
        private void MatFessorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FiddlerApplication.Shutdown();
            Environment.Exit(0);
        }
    }
}
