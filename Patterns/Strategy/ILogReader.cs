/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 августа 2026 06:51:52
 * Version: 1.0.362
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
