/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 октября 2025 06:52:00
 * Version: 1.0.46
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
