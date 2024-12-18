using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TCPLinker.Base.Utils
{
    using System;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    public static class DingDingBot
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private const string WebhookUrl = "https://oapi.dingtalk.com/robot/send?access_token=53149a7d2771a3251c722fbbaed4cd8700dbfdb966fb9db9f7f38f53ac638977";
        private const string Secret = "SEC9062f0bcc896f7eec471823927423c7db0a8e0b8e7b3eb9943dba3a021d58f8d"; // 加签密钥

        /// <summary>
        /// 生成签名
        /// </summary>
        private static string GenerateSign(long timestamp, string secret)
        {
            string stringToSign = $"{timestamp}\n{secret}";
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
            {
                byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
                string sign = Convert.ToBase64String(hash);
                return Uri.EscapeDataString(sign);
            }
        }

        /// <summary>
        /// 发送消息到钉钉群
        /// </summary>
        /// <param name="message">要发送的异常消息</param>
        public static async Task SendMessageAsync(string message)
        {
            try
            {
                // 生成时间戳和签名
                long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                string sign = GenerateSign(timestamp, Secret);

                // 构建完整的 Webhook 地址
                string signedUrl = $"{WebhookUrl}&timestamp={timestamp}&sign={sign}";

                // 发送消息的 JSON 数据
                var jsonPayload = $@"
            {{
                ""msgtype"": ""text"",
                ""text"": {{
                    ""content"": ""【异常警告】\n{message}""
                }}
            }}";

                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // 发送 POST 请求
                var response = await httpClient.PostAsync(signedUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("消息发送成功");
                }
                else
                {
                    Console.WriteLine($"发送失败: {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"发送消息时发生异常: {ex.Message}");
            }
        }
    }

}
