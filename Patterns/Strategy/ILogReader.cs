/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 августа 2026 06:51:53
 * Version: 1.0.372
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
