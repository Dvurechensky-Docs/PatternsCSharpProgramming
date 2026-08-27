/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 августа 2026 08:32:14
 * Version: 1.0.378
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
