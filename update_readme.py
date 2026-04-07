import os
import re
from collections import defaultdict

script_dir = os.path.dirname(os.path.abspath(__file__))

# Count solutions per day and by difficulty
day_solutions = defaultdict(int)
difficulty_count = {"E": 0, "M": 0, "H": 0}
total_folders = 0

for folder in os.listdir(script_dir):
    folder_path = os.path.join(script_dir, folder)
    if os.path.isdir(folder_path) and folder.startswith('Day'):
        total_folders += 1
        # Extract the day number (e.g., "Day10" from "Day10_0383_RansomNote_E")
        match = re.match(r'Day(\d+)', folder)
        if match:
            day_num = int(match.group(1))
            day_solutions[day_num] += 1
        
        # Extract difficulty level (last character before file extension)
        # Pattern: DayXXX_XXXX_ProblemName_D where D is E/M/H
        difficulty_match = re.search(r'_([EMH])$', folder)
        if difficulty_match:
            difficulty = difficulty_match.group(1)
            difficulty_count[difficulty] += 1

# Progress based on max day number (not total folder count)
total_days = 150
readme_path = os.path.join(script_dir, 'README.md')

try:
    with open(readme_path, 'r', encoding='utf-8') as file:
        content = file.read()
except FileNotFoundError:
    print(f"README.md not found at: {readme_path}")
    exit(1)

# Calculate current day (max day number found)
current_day = max(day_solutions.keys()) if day_solutions else 0

# Update the Progress Badge with day counter
badge_pattern = r'(https://img\.shields\.io/badge/Progress-)\d+(%2F150-blue)'
new_content = re.sub(badge_pattern, rf'\g<1>{current_day}\g<2>', content)

# Create difficulty badges (shields.io format)
total_solved = total_folders
easy_badge = f'https://img.shields.io/badge/Easy-{difficulty_count["E"]}-green'
medium_badge = f'https://img.shields.io/badge/Medium-{difficulty_count["M"]}-yellow'
hard_badge = f'https://img.shields.io/badge/Hard-{difficulty_count["H"]}-red'
total_badge = f'https://img.shields.io/badge/Total-{total_solved}-blue'

difficulty_badges = f'![Total]({total_badge}) ![Easy]({easy_badge}) ![Medium]({medium_badge}) ![Hard]({hard_badge})'

# Replace difficulty badges between markers
difficulty_pattern = r'(<!-- DIFFICULTY_BADGES_START -->).*?(<!-- DIFFICULTY_BADGES_END -->)'
new_content = re.sub(difficulty_pattern, rf'\1\n{difficulty_badges}\n\2', new_content, flags=re.DOTALL)

# Generate the Activity Grid (25 columns x 6 rows for 150 days)
columns = 25
number_emojis = {
    0: "⬜",  
    1: "🟩",  
    2: "2️⃣",  
    3: "3️⃣",  
    4: "4️⃣",  
    5: "5️⃣",  
    6: "6️⃣",  
    7: "7️⃣",  
    8: "8️⃣", 
    9: "9️⃣", 
}

grid_lines = ["<div align='center'>\n\n"]
for day in range(1, total_days + 1):
    count = day_solutions[day]
    emoji = number_emojis.get(count, "9️⃣")  # Default to 🟩 for counts > 9
    grid_lines.append(emoji + " ")
    
    if day % columns == 0:
        grid_lines.append("\n\n")

grid_lines.append("</div>")
grid_string = "".join(grid_lines)

# Inject the grid between the markers
grid_pattern = r'(<!-- ACTIVITY_GRID_START -->).*?(<!-- ACTIVITY_GRID_END -->)'
new_content = re.sub(grid_pattern, rf'\1\n{grid_string}\n\2', new_content, flags=re.DOTALL)

with open(readme_path, 'w', encoding='utf-8') as file:
    file.write(new_content)

print(f"Successfully updated progress to Day {current_day}/150 and refreshed the activity grid.")