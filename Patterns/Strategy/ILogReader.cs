/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 сентября 2026 06:51:51
 * Version: 1.0.408
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
