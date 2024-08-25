nodes=[]
total=int(input("Enter total number of nodes: "))
# to add
for i in range(0,total):
    node=int(input("Enter node "))
    nodes.append(node)
print("Before removal")
for i in range(0,total):
    print(nodes[i]," -> ",end='')
print("null")
# To remove
remove=int(input("Enter node to be removed: "))
nodes.remove(remove)
print("After removal")
for i in range (0,total-1):
    print(nodes[i],"-> ",end='')
print("null")