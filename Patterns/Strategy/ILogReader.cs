/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 октября 2025 06:51:54
 * Version: 1.0.49
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
