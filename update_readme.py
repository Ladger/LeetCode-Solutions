import os
import re

script_dir = os.path.dirname(os.path.abspath(__file__))

day_folders = [f for f in os.listdir(script_dir) if os.path.isdir(os.path.join(script_dir, f)) and f.startswith('Day')]
solved_count = len(day_folders)

readme_path = os.path.join(script_dir, 'README.md')

try:
    with open(readme_path, 'r', encoding='utf-8') as file:
        content = file.read()
except FileNotFoundError:
    print(f"README.md not found at: {readme_path}")
    print("Check your spelling, capitalization, and ensure there are no hidden .txt extensions.")
    exit(1)

pattern = r'(https://img\.shields\.io/badge/Progress-)\d+(%2F150-blue)'
new_content = re.sub(pattern, rf'\g<1>{solved_count}\g<2>', content)

# 5. Write the changes back to the README
with open(readme_path, 'w', encoding='utf-8') as file:
    file.write(new_content)

print(f"Successfully updated progress to {solved_count}/150")