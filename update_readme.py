import os
import re

script_dir = os.path.dirname(os.path.abspath(__file__))

# Count solved days based on folders
day_folders = [f for f in os.listdir(script_dir) if os.path.isdir(os.path.join(script_dir, f)) and f.startswith('Day')]
solved_count = len(day_folders)
total_days = 150

readme_path = os.path.join(script_dir, 'README.md')

try:
    with open(readme_path, 'r', encoding='utf-8') as file:
        content = file.read()
except FileNotFoundError:
    print(f"README.md not found at: {readme_path}")
    exit(1)

# Update the Progress Badge
badge_pattern = r'(https://img\.shields\.io/badge/Progress-)\d+(%2F150-blue)'
new_content = re.sub(badge_pattern, rf'\g<1>{solved_count}\g<2>', content)

# Generate the Activity Grid (15 columns x 10 rows)
columns = 25
grid_lines = ["<div align='center'>\n\n"]

for i in range(total_days):
    if i < solved_count:
        grid_lines.append("🟩 ") # Solved
    else:
        grid_lines.append("⬜ ") # Unsolved
        
    if (i + 1) % columns == 0:
        grid_lines.append("\n\n")

grid_lines.append("</div>")
grid_string = "".join(grid_lines)

# Inject the grid between the markers
grid_pattern = r'(<!-- ACTIVITY_GRID_START -->).*?(<!-- ACTIVITY_GRID_END -->)'
new_content = re.sub(grid_pattern, rf'\1\n{grid_string}\n\2', new_content, flags=re.DOTALL)

with open(readme_path, 'w', encoding='utf-8') as file:
    file.write(new_content)

print(f"Successfully updated progress to {solved_count}/150 and refreshed the activity grid.")