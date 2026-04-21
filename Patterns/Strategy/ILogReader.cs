/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:51:38
 * Version: 1.0.247
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
