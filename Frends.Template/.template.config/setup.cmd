for %%f in (".\workflows\") do (
	move %%f "../.github/workflows\%%~nf"
)
echo "worflow files moved."