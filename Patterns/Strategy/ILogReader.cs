/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:11
 * Version: 1.0.242
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
