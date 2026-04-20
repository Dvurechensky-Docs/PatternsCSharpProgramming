/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:06
 * Version: 1.0.245
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
