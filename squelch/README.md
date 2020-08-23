# Squelch

## Todo / Enhancements
1. [Improvement] Add a statistics fragment.
2. [Improvement] Move to a bottom panel navigation scheme vs a slide navigation panel.
3. [Feature] Add recurring schedules (perhaps use crontab?).
4. [Improvement] Make the setup process more visually appealing.
5. [Feature] Add additional modes into the blackout process, such as VPN mode.
6. [Feature] Add pre-set app list(s) that users can define for the blackout setup process.
7. [Feature] Add quick blackout options to home fragment (quick 30 mins, full lockouts, etc).
8. [Improvement] Modify how the quick options work for date selection on the BlackoutSetupFragment. It can be confusing for the user to select "NOW" and by the time they are done setting it up, time has already passed.
9. [Improvement] Cleanup static helper utils.
10. [Feature] Add trash talk option to overlay (user configurable).
11. [Bug] Views that use alert dialogs need to start storing those dialogs at the instance level, and close them OnDestroy(). It appears that under the right conditions (CPU usage, etc) the app does not react quick enough to user input, allowing multiple dialogs to be shown and some dialogs to persist even after the fragment/activity has been destroyed. Refer to BlackoutFragment for samples.
12. [Improvement] Add a job scheduler that checks to see if the EnforcerService is running, and if not, start it back up.

## Changelog:
1. Firebase analytics tested to be repoting proper values.
2. Added permission settings to SettingsFragment.
3. Resolved double detection issue with the application overlay feature in the EnforcerService. Issue was resolved by adding a small delay to the enforcement service that prevents a check immedaitely after the overlay is closed.
4. Changed the difficulty names from easy, medium, hard to novice, veteran, master respectively.