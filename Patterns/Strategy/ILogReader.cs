/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 августа 2026 06:51:46
 * Version: 1.0.376
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
