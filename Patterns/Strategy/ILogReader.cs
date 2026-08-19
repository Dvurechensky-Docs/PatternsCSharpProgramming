/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 августа 2026 10:21:40
 * Version: 1.0.370
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
