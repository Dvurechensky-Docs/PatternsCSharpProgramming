/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 сентября 2026 06:53:47
 * Version: 1.0.399
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
