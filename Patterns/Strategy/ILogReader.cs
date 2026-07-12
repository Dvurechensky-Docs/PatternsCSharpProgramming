/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 июля 2026 06:51:48
 * Version: 1.0.332
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
