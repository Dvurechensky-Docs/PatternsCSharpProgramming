/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:36:51
 * Version: 1.0.248
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
