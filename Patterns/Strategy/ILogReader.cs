/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 марта 2026 12:20:36
 * Version: 1.0.225
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
