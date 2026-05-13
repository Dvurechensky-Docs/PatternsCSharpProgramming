/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 мая 2026 06:51:40
 * Version: 1.0.271
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
