#!/bin/bash
find . -type f -name "*Conduit*" | while read -r file; do
  # Check if file actually exists
  if [[ -e "$file" ]]; then
    # Replace "HB" with "EB" in the filename
    new_file="$(dirname "$file")/$(basename "${file//Conduit/Selector}")"
    # Rename the file
    mv "$file" "$new_file"
    echo "Renamed: $file -> $new_file"
  fi
done