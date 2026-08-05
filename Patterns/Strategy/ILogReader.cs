/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 августа 2026 06:51:46
 * Version: 1.0.356
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
