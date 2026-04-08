/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:27:06
 * Version: 1.0.234
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
