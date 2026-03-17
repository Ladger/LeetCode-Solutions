import os
import re

day_folders = [f for f in os.listdir('.') if os.path.isdir(f) and f.startswith('Day')]
solved_count = len(day_folders)

readme_path = 'README.md'
try:
    with open(readme_path, 'r', encoding='utf-8') as file:
        content = file.read()
except FileNotFoundError:
    print("README.md not found. Please create one.")
    exit(1)

pattern = r'(https://progress-bar\.dev/)\d+(/\?scale=150)'
new_content = re.sub(pattern, rf'\g<1>{solved_count}\g<2>', content)

with open(readme_path, 'w', encoding='utf-8') as file:
    file.write(new_content)

print(f"Successfully updated progress to {solved_count}/150")