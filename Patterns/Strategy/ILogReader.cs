/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 октября 2025 08:38:46
 * Version: 1.0.51
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
