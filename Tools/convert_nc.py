import netCDF4 as nc

# Open the NetCDF file
nc_file = 'your_file.nc'
dataset = nc.Dataset(nc_file, 'r')

# Open a text file to write the data
txt_file = 'output.txt'
with open(txt_file, 'w') as f:
    # Iterate through all variables in the NetCDF file
    for var_name in dataset.variables:
        var = dataset.variables[var_name]
        f.write(f'Variable: {var_name}\n')
        f.write(f'Dimensions: {var.dimensions}\n')
        f.write(f'Shape: {var.shape}\n')
        f.write(f'Data:\n{var[:].data}\n\n')

# Close the NetCDF file
dataset.close()

print(f'Data has been written to {txt_file}')
